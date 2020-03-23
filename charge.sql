--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CHARGE
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."CHARGE" 
   (	"ID" NUMBER, 
	"AMOUNT" FLOAT(126)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.CHARGE
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index CHARGE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."CHARGE_PK" ON "AQUAPARK"."CHARGE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table CHARGE
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CHARGE" ADD CONSTRAINT "CHARGE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
