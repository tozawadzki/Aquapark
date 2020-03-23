--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table WATCH
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."WATCH" 
   (	"ID" NUMBER, 
	"CUSTOMERID" NUMBER, 
	"SERVICEID" NUMBER, 
	"CHARGEID" NUMBER
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.WATCH
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index WATCH_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."WATCH_PK" ON "AQUAPARK"."WATCH" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table WATCH
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."WATCH" ADD CONSTRAINT "WATCH_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table WATCH
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."WATCH" ADD CONSTRAINT "FK_CUSTOMERID_WATCH" FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "AQUAPARK"."CUSTOMER" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."WATCH" ADD CONSTRAINT "FK_SERVICEID_WATCH" FOREIGN KEY ("SERVICEID")
	  REFERENCES "AQUAPARK"."SERVICES" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."WATCH" ADD CONSTRAINT "FK_CHARGEID_WATCH" FOREIGN KEY ("CHARGEID")
	  REFERENCES "AQUAPARK"."CHARGE" ("ID") ENABLE;
