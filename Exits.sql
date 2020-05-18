--------------------------------------------------------
--  File created - poniedzia³ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table EXITS
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."EXITS" 
   (	"ID" NUMBER, 
	"WATCHID" NUMBER, 
	"TIME" DATE
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.EXITS
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index EXIT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."EXIT_PK" ON "AQUAPARK"."EXITS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table EXITS
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."EXITS" ADD CONSTRAINT "EXIT_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "AQUAPARK"."EXITS" MODIFY ("WATCHID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."EXITS" MODIFY ("TIME" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table EXITS
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."EXITS" ADD CONSTRAINT "FK_WATCHID_EXIT" FOREIGN KEY ("WATCHID")
	  REFERENCES "AQUAPARK"."WATCHES" ("ID") ENABLE;
