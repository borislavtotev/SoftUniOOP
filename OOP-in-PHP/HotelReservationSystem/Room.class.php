<?php
require_once 'iReservable.php';
require_once 'EReservationException.php';

class Room implements iReservable {
	private $roomType;
	private $hasRestRoom;
	private $hasBalcony;
	private $bedCount;
	private $roomNumber;
	private $extras;
	private $price;
	private $reservations = [];
	
	public function __construct($roomType, $roomNumber, $price, $hasRestRoom = true, 
			$hasBalcony = false, $bedCount = 2, $extras = [] ) {
		$this->setRoomType($roomType);
		$this->setRoomNumber($roomNumber);
		$this->setPrice($price);
		$this->setHasBalcony($hasBalcony);
		$this->setHasRestRoom($hasRestRoom);
		$this->setBedCount($bedCount);
		$this->setExtras($extras);
	}
	
	public function getRoomType() {
		return $this->roomType;
	}
	
	public function setRoomType($roomType) {
		$roomType = RoomType::getRoomTypeString($roomType);
		if ($roomType == null) {
			throw new Exception("Invalid Type of room!");
		}
		
		$this->roomType = $roomType;
	}
	
	public function getHasRestRoom() {
		return $this->hasRestRoom;
	}
	
	public function setHasRestRoom($hasRestRoom) {
		if ($hasRestRoom != false && $hasRestRoom != true) {
			throw new Exception("Invalid argument has rest room. It can be only true or false.");
		}
		
		$this->hasRestRoom = $hasRestRoom;
	}	

	public function getHasBalcony() {
		return $this->hasBalcony;
	}
	
	public function setHasBalcony($hasBalcony) {
		if ($hasBalcony != false && $hasBalcony != true) {
			throw new Exception("Invalid argument has rest room. It can be only true or false.");
		}
		
		$this->hasBalcony = $hasBalcony;
	}
	
	public function getBedCount() {
		return $this->bedCount;
	}
	
	public function setBedCount($bedCount) {
		if ($bedCount > 0 && is_int($bedCount)) {
			$this->bedCount = $bedCount;
		} else {
			throw new Exception("The room bed must be integer number greater than 0.");
		}	
	}
	
	public  function getRoomNumber() {
		return $this->roomNumber;	
	}
	
	public function setRoomNumber($roomNumber) {
		if ($roomNumber > 0 && is_int($roomNumber)) {
			$this->roomNumber = $roomNumber;
		} else {
			throw new Exception("The room number must be integer number greater than 0.");
		}
	}
	
	public function getPrice() {
		return $this->price;
	}
	
	public function setPrice($price) {
		if ($price > 0) {
			$this->price = $price;
		} else {
			throw new Exception("The price must be greater than 0.");
		}
	}
	
	public function getExtras() {
		return $this->extras;
	}
	
	public function setExtras($extras) {
		if (is_array($extras)) {
			$this->extras = $extras;;
		} else {
			throw new Exception("The extras must be provided in array!");
		}
		
	}
	
	public function __toString() {
		$roomType = $this::getRoomType();	
		$result = "Room $this->roomNumber is a $roomType room. It has $this->bedCount beds. The price is $this->price . "; 
		
		if ($this->hasBalcony) {
			$result.= "It has balcony. ";
		}
		
		if ($this->hasRestRoom) {
			$result.= "The room has rest room. ";
		}

		if ($this->extras != []) {
			$result.= "Extras (" . implode(", ", $this->extras) . ")";
		}
		
		return $result;
	}
	
	public function addReservation($reservation) {
		if (! $reservation instanceof Reservation) {
			throw new Exception("Invalid reservation!");
		}
		
		$hasOverlap = false;
		
		// check for overlapped periods
		foreach ($this->reservations as $oldReservation) {
			$startDate = strtotime($oldReservation->getStartDate());
			$endDate = strtotime($oldReservation->getEndDate());
			
			$newStartDate = strtotime($reservation->getStartDate());
			$newEndDate = strtotime($reservation->getEndDate());

			if ( ($newStartDate >= $startDate && $newStartDate <= $endDate) ||
					($newEndDate >= $startDate && $newEndDate <= $endDate)
				) {
				$hasOverlap = true;
				break;
			}
		}
		
		if ($hasOverlap) {
			throw new EReservationException($reservation->getStartDate(), $reservation->getEndDate());
		} else {
			array_push($this->reservations, $reservation);
		}
	}
	
	public function removeReservation($reservation) {
		$arrayWithoutReservation = array_diff($this->reservations, array($reservation));
		$this->reservations = $arrayWithoutReservation;
	}
	
	public function getReservations() {
		$result = "Reservations (" . implode(", ", $this->reservations) . ")";
		return $result;
	}
	
	public function getReservationsArray() {
		return $this->reservations;
	}
}