<?php

class Reservation
{
	private $startDate;
	private $endDate;
	private $guest;

	public function __construct($startDate, $endDate, $guest) {
		$this->setStartDate($startDate);
		$this->setEndDate($endDate);
		$this->setGuest($guest);
	}
	
	public function getStartDate() {
		$startDate = date('d.m.Y', $this->startDate);
		return $startDate;
	}

	public function setStartDate($startDate) {
		$this->startDate = $startDate;
	}

	public function getEndDate() {
		$endDate = date('d.m.Y', $this->endDate);
		return $endDate;
	}

	public function setEndDate($endDate) {
		$this->endDate = $endDate;
	}

	public function getGuest() {
		return $this->guest;
	}

	public function setGuest($guest) {
		if ($guest instanceof Guest) {
			$this->guest = $guest;
		} else {
			throw new Exception("Invalid guest!");
		}
	}

	public function __toString() {
		$result = 'Reservation for ' . $this->guest . ' from ' . $this->getStartDate() . ' to ' . $this->getEndDate();
		return $result;
	}
}