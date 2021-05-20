drop table reviews
drop table restaurants
 --table definition
 create table restaurants
 (
     id int identity primary key,
     name nvarchar(50) not null,
     city nvarchar(50) not null,
     state nvarchar(50) not null
 );

 create table reviews 
 (
     id int identity primary key,
     rating int not null,
     description nvarchar(240) not null,
     restaurantID int references restaurants(id) on delete cascade
 );

 --seeding the database
 insert into restaurants (name, city, state) values
 ('Balajadias', 'Baguio City', 'Benguet'),
 ('Hanoi Chicken Noodle', 'San Leandro', 'California');

 insert into reviews (rating, description, restaurantID) values
 (5, 'Very good', 1),
 (5, 'Amazing', 2);
