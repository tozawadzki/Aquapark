--------------------------------------------------------
--  File created - poniedzia³ek-marca-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table EXIT
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."EXIT" 
   (	"ID" NUMBER, 
	"WATCHID" NUMBER, 
	"TIME" DATE
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.EXIT
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index EXIT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."EXIT_PK" ON "AQUAPARK"."EXIT" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table EXIT
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."EXIT" ADD CONSTRAINT "EXIT_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EXIT
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."EXIT" ADD CONSTRAINT "FK_WATCHID_EXIT" FOREIGN KEY ("WATCHID")
	  REFERENCES "AQUAPARK"."WATCH" ("ID") ENABLE;
