--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table SERVICES
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."SERVICES" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(60 BYTE), 
	"PRICEPERHOUR" NUMBER, 
	"PRICEPERMINUTE" NUMBER
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.SERVICES
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index SERVICES_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."SERVICES_PK" ON "AQUAPARK"."SERVICES" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table SERVICES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."SERVICES" ADD CONSTRAINT "SERVICES_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
