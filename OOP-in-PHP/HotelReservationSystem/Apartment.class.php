<?php

class Apartment extends Room
{
	public function __construct($roomNumber, $price) {
		parent::__construct(RoomType::Diamond, $roomNumber, $price, true, true, 4, ['TV', 'air-conditioner',
						 	'refrigerator', 'mini-bar', 'bathtub', 'kitchen box', 'free Wi-fi']);
	}
}