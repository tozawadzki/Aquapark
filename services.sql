--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table SERVICES
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."SERVICES" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(60 BYTE), 
	"PRICEPERHOUR" NUMBER, 
	"PRICEPERMINUTE" NUMBER, 
	"ENTRANCEMETHODID" NUMBER(*,0)
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
  ALTER TABLE "AQUAPARK"."SERVICES" MODIFY ("NAME" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."SERVICES" MODIFY ("PRICEPERHOUR" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."SERVICES" MODIFY ("PRICEPERMINUTE" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."SERVICES" MODIFY ("ENTRANCEMETHODID" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table SERVICES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."SERVICES" ADD CONSTRAINT "ENMETID" FOREIGN KEY ("ENTRANCEMETHODID")
	  REFERENCES "AQUAPARK"."ENTRANCEMETHOD" ("ID") ENABLE;
