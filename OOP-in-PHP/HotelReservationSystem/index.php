<?php

function __autoload($className) {
	require_once ($className . ".class.php");
}

try {
	$room = new SingleRoom(1408, 99);
	$guest = new Guest("Svetlin", "Nakov", 8003224277);
	$startDate = strtotime("24.10.2014");
	$endDate = strtotime("26.10.2014");
	$reservation = new Reservation($startDate, $endDate, $guest);
	BookingManager::bookRoom($room, $reservation);

	$reservation2 = new Reservation(strtotime("20.10.2014"), strtotime("23.10.2014"), $guest);
	BookingManager::bookRoom($room, $reservation2);
	
	// test removeReservation method
	echo '<p><strong>Current Reservations</strong><br/>';
	echo $room->getReservations() . '<br/>';
	echo  '<strong>Reservation after remove of the first reservation:</strong><br/>';
	$room->removeReservation($reservation);
	echo $room->getReservations() . '</p>';
		
	// test custom exception when the room is booked
	$reservation3 = new Reservation(strtotime("24.10.2014"), strtotime("27.10.2014"), $guest);
	BookingManager::bookRoom($room, $reservation2);
} catch (EReservationException $e) {
	echo '<strong>'. $e->getMessage() .'</strong>';
} catch (Exception $e) {
	echo "<strong>$e</strong>";
}

echo "<p></p>";

// Create array of rooms to test filters
$room1 = new SingleRoom(1408, 99);
$room2 = new SingleRoom(1409, 109);
$room3 = new BedRoom(2009, 250);
$room4 = new BedRoom(2008, 215);
$room5 = new BedRoom(2007, 275);
$room6 = new Apartment(3001, 250);
$room7 = new Apartment(3002, 300);
$room8 = new Apartment(3003, 350);

$rooms = [$room1, $room2, $room3, $room4, $room5, $room6, $room7, $room8];

// Filter the array by bedrooms and apartments with a price less or equal to 250.00
$bedroomAndApartmentsLess250 = 
	array_map(function($rooms) { return $rooms->getRoomNumber(); }, // get the room numbers for easily test 
		array_filter($rooms, 
			function ($room) { 
				return ($room instanceof BedRoom || $room instanceof Apartment) && ($room->getPrice() <= 250);
			}	
		)
	);

echo var_dump($bedroomAndApartmentsLess250). '<br/>';

// Filter the array by all rooms with a balcony
$roomsWithBalcony =
	array_map(function($rooms) { return $rooms->getRoomNumber(); }, // get the room numbers for easily test 
		array_filter($rooms,
					function ($room) {
						return $room->getHasBalcony();
					}
		)
	);
	
echo var_dump($roomsWithBalcony). '<br/>';

// Return the room numbers of all rooms which have a bathtub in their extras
$roomsWithBathtub =
	array_map(function($rooms) { return $rooms->getRoomNumber(); }, // get the room numbers for easily test
		array_filter($rooms,
				function ($room) {
					return in_array('bathtub', $room->getExtras());
				}
		)
	);

echo var_dump($roomsWithBathtub). '<br/>';

//Filter the array by all apartments which are not booked in a given time period (e.g. between 17.10.2014 and 19.10.2014
$reservationNew1 = new Reservation(strtotime("15.10.2014"), strtotime("18.10.2014"), $guest);
$reservationNew2 = new Reservation(strtotime("10.10.2014"), strtotime("15.10.2014"), $guest);
$reservationNew3 = new Reservation(strtotime("20.10.2014"), strtotime("30.10.2014"), $guest);

BookingManager::bookRoom($room6, $reservationNew1);
BookingManager::bookRoom($room7, $reservationNew2);
BookingManager::bookRoom($room8, $reservationNew3);

$apartmentsNotBookedInPeriod =
	array_map(function($rooms) { return $rooms->getRoomNumber(); }, // get the room numbers for easily test
		array_filter($rooms,
				function ($room) { 
					if (! $room instanceof Apartment) {
						return false; 
					}
					
					$reservations = $room->getReservationsArray();
					
					// get the reservation with overlapped period
					$overlappedReservations = 
						array_filter($reservations, 
							function ($reservation) {
								$startDate = strtotime($reservation->getStartDate());
								$endDate = strtotime($reservation->getEndDate());
								
								$newStartDate = strtotime("17.10.2014");
								$newEndDate = strtotime("19.10.2014");
								return ($newStartDate >= $startDate && $newStartDate <= $endDate) ||
										($newEndDate >= $startDate && $newEndDate <= $endDate);
							}
						);
					
					// return true when there are no reservation which are for this period
					return (sizeof($overlappedReservations) == 0);
				}
		)
	);

echo "The apartments which are not booked between 17.10.2014 and 19.10.2014 are with numbers:<br/>";
echo var_dump($apartmentsNotBookedInPeriod). '<br/>';