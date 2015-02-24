<?php

class BookingManager
{
	private $room;
	private $reservation;
	
	public static function bookRoom(Room $room, Reservation $reservation) {
		$room->addReservation($reservation);
		
		$result = '<p>Room <strong>' . $room->getRoomNumber() . '</strong> successfully booked for <strong>' .
					$reservation->getGuest()->getFirstName() . ' ' . $reservation->getGuest()->getLastName() .
					'</strong> from <time>' . $reservation->getStartDate() . '</time> to <time>' .
					$reservation->getEndDate() . '</time>!</p>';
		
		echo $result;
					
	}
}