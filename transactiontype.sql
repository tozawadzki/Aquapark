--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table TRANSACTIONTYPE
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."TRANSACTIONTYPE" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(30 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.TRANSACTIONTYPE
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index TRANSACTIONTYPE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."TRANSACTIONTYPE_PK" ON "AQUAPARK"."TRANSACTIONTYPE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table TRANSACTIONTYPE
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."TRANSACTIONTYPE" ADD CONSTRAINT "TRANSACTIONTYPE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
