--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ENTRANCEMETHOD
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."ENTRANCEMETHOD" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(60 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.ENTRANCEMETHOD
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index ENTRANCEMETHOD_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."ENTRANCEMETHOD_PK" ON "AQUAPARK"."ENTRANCEMETHOD" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table ENTRANCEMETHOD
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."ENTRANCEMETHOD" ADD CONSTRAINT "ENTRANCEMETHOD_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "AQUAPARK"."ENTRANCEMETHOD" MODIFY ("NAME" NOT NULL ENABLE);
