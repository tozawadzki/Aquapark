--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table TRANSACTION
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."TRANSACTION" 
   (	"ID" NUMBER, 
	"SERVICEID" NUMBER, 
	"TRANSACTIONTYPEID" NUMBER, 
	"WATCHID" NUMBER, 
	"TIME" DATE
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.TRANSACTION
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index TRANSACTION_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."TRANSACTION_PK" ON "AQUAPARK"."TRANSACTION" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table TRANSACTION
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."TRANSACTION" ADD CONSTRAINT "TRANSACTION_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TRANSACTION
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."TRANSACTION" ADD CONSTRAINT "FK_TRANSACTIONTYPEID" FOREIGN KEY ("TRANSACTIONTYPEID")
	  REFERENCES "AQUAPARK"."TRANSACTIONTYPE" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."TRANSACTION" ADD CONSTRAINT "FK_SERVICEID" FOREIGN KEY ("SERVICEID")
	  REFERENCES "AQUAPARK"."SERVICES" ("ID") ENABLE;
  ALTER TABLE "AQUAPARK"."TRANSACTION" ADD CONSTRAINT "FK_WATCHID" FOREIGN KEY ("WATCHID")
	  REFERENCES "AQUAPARK"."WATCH" ("ID") ENABLE;
