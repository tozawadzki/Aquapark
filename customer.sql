--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CUSTOMER
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."CUSTOMER" 
   (	"ID" NUMBER, 
	"DISCOUNTID" NUMBER
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.CUSTOMER
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index CUSTOMER_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."CUSTOMER_PK" ON "AQUAPARK"."CUSTOMER" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CUSTOMER" ADD CONSTRAINT "CUSTOMER_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CUSTOMER" ADD CONSTRAINT "FK_DISCOUNTID" FOREIGN KEY ("DISCOUNTID")
	  REFERENCES "AQUAPARK"."DISCOUNTS" ("ID") ENABLE;
