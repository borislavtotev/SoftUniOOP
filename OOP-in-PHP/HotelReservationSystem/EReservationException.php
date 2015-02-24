<?php

class EReservationException extends Exception {
	public function __construct($startDate, $endDate) {
		parent::__construct("The room is booked for some parts of the required period ($startDate - $endDate)", 101);
	}
}