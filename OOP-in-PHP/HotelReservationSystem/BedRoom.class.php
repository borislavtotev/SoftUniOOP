<?php

class BedRoom extends Room
{
	public function __construct($roomNumber, $price) {
		parent::__construct(RoomType::Gold, $roomNumber, $price, true, true, 2, ['TV', 'air-conditioner', 'refrigerator', 'mini-bar', 'bathtub']);
	}
}