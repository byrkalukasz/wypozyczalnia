CREATE TABLE PERSON
(
ID INT IDENTITY(1,1) PRIMARY KEY,
NAME VARCHAR(50) NOT NULL,
SURNAME VARCHAR(100) NOT NULL
)

INSERT INTO PERSON(NAME, SURNAME) VALUES('�ukasz','Byrka')
INSERT INTO PERSON(NAME, SURNAME) VALUES('Marcin','S�owacki')

CREATE TABLE USERD
(
ID INT IDENTITY(1,1) PRIMARY KEY,
LOGIN VARCHAR(30) NOT NULL,
PASSWORD VARCHAR(255) NOT NULL,
CREATION_DATE DATE NOT NULL,
LAST_PASS_CHAGE DATE NOT NULL,
INVALID_LOGIN_ATTEMPTS INT NOT NULL,
ACCOUT_BLOCK INT NOT NULL,
PERSON_ID INT NOT NULL,
FOREIGN KEY (PERSON_ID) REFERENCES PERSON(ID)
)

INSERT INTO USERD(LOGIN, PASSWORD, CREATION_DATE, LAST_PASS_CHAGE, INVALID_LOGIN_ATTEMPTS, ACCOUT_BLOCK, PERSON_ID) 
VALUES ('Admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','2019-12-12','2019-12-12',0,0,1)
INSERT INTO USERD(LOGIN, PASSWORD, CREATION_DATE, LAST_PASS_CHAGE, INVALID_LOGIN_ATTEMPTS, ACCOUT_BLOCK, PERSON_ID) 
VALUES ('mslowacki','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','2019-12-12','2019-12-12',0,0,2)

CREATE TABLE Car
(
ID int IDENTITY(1,1) NOT NULL, 
Producent VARCHAR(255) NOT NULL,
Marka VARCHAR(255) NOT NULL
PRIMARY KEY (ID)
)

CREATE TABLE CAR_DATA
(
ID int IDENTITY(1,1) NOT NULL, 
Rocznik VARCHAR(4) NOT NULL,
Nadwozie VARCHAR(255) NOT NULL,
LiczbaDrzwi INT NOT NULL,
MaxPasazerow INT NOT NULL,
Kolor VARCHAR(255) NOT NULL,
DataPrzegladu VARCHAR(255) NOT NULL,
DataUbezpieczenia VARCHAR(255) NOT NULL,
Przebieg INT NOT NULL,
NumerRejestracyjny VARCHAR(15) NOT NULL,
VIN VARCHAR(20) NOT NULL,
ID_CAR INT
PRIMARY KEY(ID)
FOREIGN KEY (ID_CAR) REFERENCES Car(ID)
)