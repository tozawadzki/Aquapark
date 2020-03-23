--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ENTRANCE
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."ENTRANCE" 
   (	"ID" NUMBER, 
	"WATCHID" NUMBER, 
	"ENTRANCEMETHODID" NUMBER, 
	"TIME" DATE, 
	"CUSTOMERID" NUMBER(1,0)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.ENTRANCE
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index ENTRANCE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."ENTRANCE_PK" ON "AQUAPARK"."ENTRANCE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table ENTRANCE
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."ENTRANCE" ADD CONSTRAINT "ENTRANCE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ENTRANCE
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."ENTRANCE" ADD CONSTRAINT "FK_CUSTOMERID" FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "AQUAPARK"."CUSTOMER" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."ENTRANCE" ADD CONSTRAINT "FK_ENTRANCEMETHODID" FOREIGN KEY ("ENTRANCEMETHODID")
	  REFERENCES "AQUAPARK"."ENTRANCEMETHOD" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."ENTRANCE" ADD CONSTRAINT "FK_WATCHID_ENTRANCE" FOREIGN KEY ("WATCHID")
	  REFERENCES "AQUAPARK"."WATCH" ("ID") ENABLE;
