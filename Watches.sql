--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table WATCHES
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."WATCHES" 
   (	"ID" NUMBER, 
	"CUSTOMERID" NUMBER, 
	"SERVICEID" NUMBER
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.WATCHES
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index WATCH_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."WATCH_PK" ON "AQUAPARK"."WATCHES" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table WATCHES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."WATCHES" ADD CONSTRAINT "WATCH_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "AQUAPARK"."WATCHES" MODIFY ("CUSTOMERID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."WATCHES" MODIFY ("SERVICEID" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table WATCHES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."WATCHES" ADD CONSTRAINT "FK_SERVICEID_WATCH" FOREIGN KEY ("SERVICEID")
	  REFERENCES "AQUAPARK"."SERVICES" ("ID") ENABLE;
