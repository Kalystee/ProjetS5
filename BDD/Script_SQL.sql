#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: ZONE_STOCKAGE
#------------------------------------------------------------

CREATE TABLE ZONE_STOCKAGE(
        Id               Int  Auto_increment  NOT NULL ,
        Nom              Varchar (255) NOT NULL ,
        Quantite_Max     Int NOT NULL ,
        Tps_Conservation Time NOT NULL
	,CONSTRAINT ZONE_STOCKAGE_PK PRIMARY KEY (Id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INGREDIENT
#------------------------------------------------------------

CREATE TABLE INGREDIENT(
        Id               Int  Auto_increment  NOT NULL ,
        Nom              Varchar (255) NOT NULL ,
        Quantite         Int NOT NULL ,
        DLC              Date NOT NULL ,
        Id_ZONE_STOCKAGE Int NOT NULL
	,CONSTRAINT INGREDIENT_PK PRIMARY KEY (Id)

	,CONSTRAINT INGREDIENT_ZONE_STOCKAGE_FK FOREIGN KEY (Id_ZONE_STOCKAGE) REFERENCES ZONE_STOCKAGE(Id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_RECETTE
#------------------------------------------------------------

CREATE TABLE TYPE_RECETTE(
        Id  Int  Auto_increment  NOT NULL ,
        Nom Varchar (10) NOT NULL
	,CONSTRAINT TYPE_RECETTE_PK PRIMARY KEY (Id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RECETTE
#------------------------------------------------------------

CREATE TABLE RECETTE(
        Id              Int  Auto_increment  NOT NULL ,
        Nom             Varchar (255) NOT NULL ,
        Tps_Cuisson     Time NOT NULL ,
        Tps_Preparation Time NOT NULL ,
        Tps_Repos       Time NOT NULL ,
        Nb_Personne     Int NOT NULL ,
        Accompagnement  Varchar (10) NOT NULL ,
        Id_TYPE_RECETTE Int NOT NULL
	,CONSTRAINT RECETTE_PK PRIMARY KEY (Id)

	,CONSTRAINT RECETTE_TYPE_RECETTE_FK FOREIGN KEY (Id_TYPE_RECETTE) REFERENCES TYPE_RECETTE(Id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: composer
#------------------------------------------------------------

CREATE TABLE composer(
        Id            Int NOT NULL ,
        Id_INGREDIENT Int NOT NULL
	,CONSTRAINT composer_PK PRIMARY KEY (Id,Id_INGREDIENT)

	,CONSTRAINT composer_RECETTE_FK FOREIGN KEY (Id) REFERENCES RECETTE(Id)
	,CONSTRAINT composer_INGREDIENT0_FK FOREIGN KEY (Id_INGREDIENT) REFERENCES INGREDIENT(Id)
)ENGINE=InnoDB;

