CREATE DATABASE	OrchardManagement


CREATE TABLE orchards
(orchard_id 		INT 		NOT NULL	AUTO_INCREMENT,
name			varchar(25),
username		VARCHAR(25),
password                varchar(30),
map			LONGBLOB,
email			varchar(50),
PRIMARY KEY (orchard_id) );

CREATE TABLE sections
(section_id 		INT 		NOT NULL	AUTO_INCREMENT,
orchard_id		int		not null,
name			varchar(50),
tree_type		varchar(50),
size			DECIMAL(10,2),
date_planted		date,
comment			varchar(255),
FOREIGN KEY(orchard_id) REFERENCES orchards(orchard_id),
PRIMARY KEY (section_id) );

CREATE TABLE actions
(action_id 		INT 		NOT NULL	AUTO_INCREMENT,
section_id		int		not null,
action_type		varchar(100),
date			date,
hours_invested		int,
comment			varchar(255),
FOREIGN KEY(section_id) REFERENCES sections(section_id),
PRIMARY KEY (action_id) );

CREATE TABLE harvests
(harvest_id 		INT 		NOT NULL	AUTO_INCREMENT,
section_id		int		not null,
kg_harvested		int,
date			date,
pricekg			DECIMAL(13,2),
totalincome		DECIMAL(13,2),
comment			varchar(255),
PRIMARY KEY (harvest_id) );

