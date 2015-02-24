<?php

class Guest
{
	private $firstName;
	private $lastName;
	private $id;

	public function __construct($firstName, $lastName, $id) {
		$this->setFirstName($firstName);
		$this->setLastName($lastName);
		$this->setId($id);
	}

	public function getFirstName() {
		return $this->firstName;
	}

	public function setFirstName($firstName) {
		if ($firstName == null || $firstName == '') {
			throw new Exception("The fist name can't be empty!");
		}

		$this->firstName = $firstName;
	}

	public function getLastName() {
		return $this->lastName;
	}

	public function setLastName($lastName) {
		if ($lastName == null || $lastName == '') {
			throw new Exception("The last name can't be empty!");
		}

		$this->lastName = $lastName;
	}

	public function getId() {
		return $this->id;
	}

	public function setId($id) {
		if (is_numeric($id) && $id > 0) {
			$this->id = $id;
		} else {
			throw new Exception("Invalid id!");
		}
	}
	
	public function __toString() {
		$result = "Name: $this->firstName $this->lastName ID: " . $this->getId();
		return $result;
	}
}