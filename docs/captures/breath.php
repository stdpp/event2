<?php

for ($i=0; $i<100; $i++)
{
	echo BreathingCurve($i) . "\r\n";
}

function BreathingCurve($t)
{
	//constants on time axis:
	$tA = 10;
	$tB = 20;	//end negative pressure
	$tC = 30; 	//end rise up
	$tD = 60;	//end inspiration
	$tE = 70;	//expiration
	$tF = 100;	//end
	
	$LA = -40;	//negative pressure peak
	$LB = 100;	//positive pressure set level
	$LC = 100;
	$LD = 40;	//vertical offset
	
	
	$ret = 	0 * Window(0, $tA, $t) + 
			$LA * Window($tA, $tB, $t) * sin( pi()*($t-$tA)/($tB - $tA) ) + 
			$LB * Window($tB, $tC, $t) * (1 - exp(-($t - $tB) ) ) +
			$LC * Window($tC, $tD, $t) +
			$LC * Window($tD, $tE, $t) * (exp(-($t - $tD) ) ) +
			(0) * Window($tE, $tF, $t)
			+ $LD;
	$ret = floor($ret);
	return $ret;
}

function Window($a, $b, $t)
{
	if ($a <= $t && $t < $b) return 1;
	return 0;
}

function positive($a)
{
	if ($a < 0) return 0;
	return $a;
}



