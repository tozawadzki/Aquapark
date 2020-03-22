alter table CUSTOMER
add constraint customer_pk primary key(ID);
alter table CUSTOMERS
add constraint customers_pk primary key(ID);
alter table DISCOUNTS
add constraint discounts_pk primary key(ID);
alter table ENTRANCE
add constraint entrance_pk primary key(ID);
alter table ENTRANCEMETHOD
add constraint entrancemethod_pk primary key(ID);
alter table EXIT
add constraint exit_pk primary key(ID);
alter table SERVICES
add constraint services_pk primary key(ID);
alter table TRANSACTION
add constraint transaction_pk primary key(ID);
alter table TRANSACTIONTYPE
add constraint transactiontype_pk primary key(ID);
alter table WATCH
add constraint watch_pk primary key(ID);

ALTER TABLE transactiontype
DROP CONSTRAINT fk_transactiontypeid;