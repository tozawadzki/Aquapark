--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table TRANSACTIONTYPES
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."TRANSACTIONTYPES" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(30 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.TRANSACTIONTYPES
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index TRANSACTIONTYPE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."TRANSACTIONTYPE_PK" ON "AQUAPARK"."TRANSACTIONTYPES" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table TRANSACTIONTYPES
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."TRANSACTIONTYPES" ADD CONSTRAINT "TRANSACTIONTYPE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "AQUAPARK"."TRANSACTIONTYPES" MODIFY ("NAME" NOT NULL ENABLE);
