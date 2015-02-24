<?php

class SingleRoom extends Room
{
	public function __construct($roomNumber, $price) {
		parent::__construct(RoomType::Standard, $roomNumber, $price, true, false, 1, ['TV', 'air-conditioner']);
	}
}