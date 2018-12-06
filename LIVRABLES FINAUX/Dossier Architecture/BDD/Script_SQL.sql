/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: ZONE_STOCKAGE
------------------------------------------------------------*/
CREATE TABLE ZONE_STOCKAGE(
	Id                 INT IDENTITY (1,1) NOT NULL ,
	Nom                VARCHAR (255) NOT NULL ,
	Quantite_Max       INT  NOT NULL ,
	Tps_Conservation   TIME (2) NOT NULL  ,
	CONSTRAINT ZONE_STOCKAGE_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: INGREDIENT
------------------------------------------------------------*/
CREATE TABLE INGREDIENT(
	Id                 INT IDENTITY (1,1) NOT NULL ,
	Nom                VARCHAR (255) NOT NULL ,
	Quantite           INT  NOT NULL ,
	DLC                DATETIME NOT NULL ,
	Id_ZONE_STOCKAGE   INT  NOT NULL  ,
	CONSTRAINT INGREDIENT_PK PRIMARY KEY (Id)

	,CONSTRAINT INGREDIENT_ZONE_STOCKAGE_FK FOREIGN KEY (Id_ZONE_STOCKAGE) REFERENCES ZONE_STOCKAGE(Id)
);


/*------------------------------------------------------------
-- Table: TYPE_RECETTE
------------------------------------------------------------*/
CREATE TABLE TYPE_RECETTE(
	Id    INT IDENTITY (1,1) NOT NULL ,
	Nom   VARCHAR (10) NOT NULL  ,
	CONSTRAINT TYPE_RECETTE_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: RECETTE
------------------------------------------------------------*/
CREATE TABLE RECETTE(
	Id                INT IDENTITY (1,1) NOT NULL ,
	Nom               VARCHAR (255) NOT NULL ,
	Tps_Cuisson       TIME (2) NOT NULL ,
	Tps_Preparation   TIME (2) NOT NULL ,
	Tps_Repos         TIME (2) NOT NULL ,
	Nb_Personne       INT  NOT NULL ,
	Accompagnement    VARCHAR (10) NOT NULL ,
	Id_TYPE_RECETTE   INT  NOT NULL  ,
	CONSTRAINT RECETTE_PK PRIMARY KEY (Id)

	,CONSTRAINT RECETTE_TYPE_RECETTE_FK FOREIGN KEY (Id_TYPE_RECETTE) REFERENCES TYPE_RECETTE(Id)
);


/*------------------------------------------------------------
-- Table: composer
------------------------------------------------------------*/
CREATE TABLE composer(
	Id              INT  NOT NULL ,
	Id_INGREDIENT   INT  NOT NULL  ,
	CONSTRAINT composer_PK PRIMARY KEY (Id,Id_INGREDIENT)

	,CONSTRAINT composer_RECETTE_FK FOREIGN KEY (Id) REFERENCES RECETTE(Id)
	,CONSTRAINT composer_INGREDIENT0_FK FOREIGN KEY (Id_INGREDIENT) REFERENCES INGREDIENT(Id)
);



