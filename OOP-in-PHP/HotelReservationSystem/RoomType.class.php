<?php

abstract class RoomType
{
    const Standard = 1;
    const Gold = 2;
	const Diamond = 3;
	
	public static function getRoomTypeString($number) {
		switch ($number) {
			case 1:
				$roomType = "Standard";
				break;
			case 2:
				$roomType = "Gold";
				break;
			case 3:
				$roomType = "Diamond";
				break;
			default:
				$roomType = null;
				break;
		}
		
		return $roomType;
	}
}
