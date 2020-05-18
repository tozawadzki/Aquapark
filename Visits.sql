--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table VISITS
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."VISITS" 
   (	"ID" NUMBER(*,0), 
	"WATCHID" NUMBER(*,0), 
	"CUSTOMERID" NUMBER(*,0), 
	"SERVICEID" NUMBER(*,0), 
	"EXITPAYMENT" NUMBER(*,0)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.VISITS
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index VISITS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."VISITS_PK" ON "AQUAPARK"."VISITS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table VISITS
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."VISITS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."VISITS" MODIFY ("WATCHID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."VISITS" MODIFY ("CUSTOMERID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."VISITS" MODIFY ("SERVICEID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."VISITS" ADD CONSTRAINT "VISITS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table VISITS
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."VISITS" ADD CONSTRAINT "WID" FOREIGN KEY ("WATCHID")
	  REFERENCES "AQUAPARK"."WATCHES" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."VISITS" ADD CONSTRAINT "CID" FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "AQUAPARK"."CUSTOMERS" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."VISITS" ADD CONSTRAINT "SID" FOREIGN KEY ("SERVICEID")
	  REFERENCES "AQUAPARK"."SERVICES" ("ID") ENABLE;
