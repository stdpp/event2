<?php

// 

define ("HARDCODED_TIME_RES", 100);


$strBrCurve = GetSerializedBreathingCurve();
echo $strBrCurve;

function GetSerializedBreathingCurve()
{
	$brCurve = [];
	for ($i=0; $i<HARDCODED_TIME_RES; $i++)
	{
		$brCurve[$i] = BreathingCurve($i);
	}
	
	echo "Breathing Curve debug for excel:\n\r";
	curvePrint($brCurve);		//for excel quick debug
	echo "\n\r";

	$conf = getDefaultConf();
	//$strBrCurve = "<FromPC DB br='" . base64_encode(curveToASCII($brCurve, $conf)) . "' tA='". $conf->tA ."' tB='". $conf->tB ."' tC='". $conf->tC ."' tD='". $conf->tD ."' tE='". $conf->tE ."' tF='". $conf->tF ."' LA='". $conf->LA ."' LB='". $conf->LB ."' LC='". $conf->LC ."' LD='". $conf->LD ."' go='go'/>\r\n";
	$strBrCurve = "<FromPC DB br='" . curveToPrintableASCII($brCurve, $conf) . "' tA='". $conf->tA ."' tB='". $conf->tB ."' tC='". $conf->tC ."' tD='". $conf->tD ."' tE='". $conf->tE ."' tF='". $conf->tF ."' LA='". $conf->LA ."' LB='". $conf->LB ."' LC='". $conf->LC ."' LD='". $conf->LD ."' sp='". $conf->sp ."' md='". $conf->md ."' go='go'/>\r\n";
	return $strBrCurve;
}

function BreathingCurve($t, $overrideconf=null)
{
	$conf = getDefaultConf();
	if ($overrideconf && $overrideconf->tA && $overrideconf->tB && $overrideconf->tC && $overrideconf->tD && $overrideconf->tE && $overrideconf->tF && $overrideconf->LA && $overrideconf->LB && $overrideconf->LC && $overrideconf->LD)
	{
		$conf->tA = $overrideconf->tA;
		$conf->tB = $overrideconf->tB;
		$conf->tC = $overrideconf->tC;
		$conf->tD = $overrideconf->tD;
		$conf->tE = $overrideconf->tE;
		$conf->tF = $overrideconf->tF;
		
		$conf->LA = $overrideconf->LA;
		$conf->LB = $overrideconf->LB;
		$conf->LC = $overrideconf->LC;
		$conf->LD = $overrideconf->LD;
	}
	$ret = 	0 * Window(0, $conf->tA, $t) + 
			$conf->LA * Window($conf->tA, $conf->tB, $t) * sin( pi()*($t-$conf->tA)/($conf->tB - $conf->tA) ) + 
			$conf->LB * Window($conf->tB, $conf->tC, $t) * (1 - exp(-($t - $conf->tB) ) ) +
			$conf->LC * Window($conf->tC, $conf->tD, $t) +
			$conf->LC * Window($conf->tD, $conf->tE, $t) * (exp(-($t - $conf->tD) ) ) +
			(0) * Window($conf->tE, $conf->tF, $t)
			+ $conf->LD;
	$ret = floor($ret);
	return $ret;
}

function Window($a, $b, $t)		//window fn
{
	if ($a <= $t && $t < $b) return 1;
	return 0;
}

function positive($a)
{
	if ($a < 0) return 0;
	return $a;
}


function Integral($t1, $t2, $step, $f)
{
	$I=0;
	for ($t=$t1; $t < $t2; $t=$t + 1)
	{
		$I = $I + $step * $f[$t];
	}
	return $I;
}

function curvePrint($fn)
{
	for ($i=0; $i<HARDCODED_TIME_RES; $i++)
	{
		echo $fn[$i] . "\r\n";
	}
}

function curveToASCII($curve)
{
	$str = "";
	for ($i=0; $i<HARDCODED_TIME_RES; $i++)
	{
		$str = $str . chr($curve[$i]);
	}
	return $str;
}

function curveToPrintableASCII($curve, $conf)
{
	//resample all the curve to take it to [32;127] integers in voltage axis
	$scaledCurve = [];
	$str = "";
	
	$min = 1000;
	$max = -1000;
	//for ($i=0; $i<HARDCODED_TIME_RES; $i++)
	//{
	//	if ($curve[$i] < $min) $min = $curve[$i];
	//	if ($curve[$i] > $max) $max = $curve[$i];
	//}
	$min = $conf->LA;
	$max = $conf->LB;
	
	for ($i=0; $i<HARDCODED_TIME_RES; $i++)
	{
		$scaledCurve[$i] = floor( (127-32)/( abs($max-$min) )*$curve[$i] + 32);
		$str = $str . chr($scaledCurve[$i]);
	}
	//echo "scaledCurve:\n\r";
	//curvePrint($scaledCurve);
	return $str;
}


function getDefaultConf()
{
	//constants on time axis:
	$conf = new StdClass();
	$conf->tA = 10;		//close inspiration valve A, and expiration valve B.
	$conf->tB = 20;		//end negative pressure
	$conf->tC = 30; 	//end rise up
	$conf->tD = 60;		//end inspiration: open expiration valve B.
	$conf->tE = 70;		//expiration
	$conf->tF = HARDCODED_TIME_RES;	//end
	//constants on voltage axis:
	$conf->LA = -40;	//negative pressure peak
	$conf->LB = 120;	//positive pressure set level
	$conf->LC = 120;	//plateau pressure
	$conf->LD = 40;		//vertical offset
	
	$conf->md = 1;		//mode label / designation
	$conf->sp = 32;		//speed
	
	return $conf;
}