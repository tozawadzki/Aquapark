--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CHARGES
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."CHARGES" 
   (	"ID" NUMBER, 
	"AMOUNT" FLOAT(126), 
	"WATCHID" NUMBER
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.CHARGES
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index CHARGE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."CHARGE_PK" ON "AQUAPARK"."CHARGES" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table CHARGES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CHARGES" ADD CONSTRAINT "CHARGE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "AQUAPARK"."CHARGES" MODIFY ("AMOUNT" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."CHARGES" MODIFY ("WATCHID" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table CHARGES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CHARGES" ADD CONSTRAINT "WATCHID" FOREIGN KEY ("WATCHID")
	  REFERENCES "AQUAPARK"."WATCHES" ("ID") ENABLE;
