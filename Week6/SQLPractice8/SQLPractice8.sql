--1.madde
create table employee (
	id serial primary key,
	name varchar(50) not null,
	birthday date,
	email varchar(100)
)

--2.madde
insert into employee (name, birthday, email) values ('Pietrek', '4/5/2024', 'pleet0@studiopress.com');
insert into employee (name, birthday, email) values ('Lucilia', '1/6/2025', 'lilliston1@bloglines.com');
insert into employee (name, birthday, email) values ('Benedetta', '9/29/2024', 'ballpress2@exblog.jp');
insert into employee (name, birthday, email) values ('Ninon', '4/7/2024', 'ntestro3@seattletimes.com');
insert into employee (name, birthday, email) values ('Ali', '8/22/2024', 'agrenter4@seesaa.net');
insert into employee (name, birthday, email) values ('Dora', '5/2/2024', 'dbadder5@hhs.gov');
insert into employee (name, birthday, email) values ('Sandor', '1/16/2025', 'szettler6@acquirethisname.com');
insert into employee (name, birthday, email) values ('Erica', '3/29/2024', 'estampe7@ow.ly');
insert into employee (name, birthday, email) values ('Corine', '2/8/2024', 'cfickling8@ibm.com');
insert into employee (name, birthday, email) values ('Ealasaid', '11/16/2024', 'ecanelas9@free.fr');
insert into employee (name, birthday, email) values ('Joleen', '5/10/2024', 'jconyersa@nsw.gov.au');
insert into employee (name, birthday, email) values ('Nona', '2/7/2024', 'njedrzejczakb@zimbio.com');
insert into employee (name, birthday, email) values ('Leslie', '5/12/2024', 'lsummerskillc@slideshare.net');
insert into employee (name, birthday, email) values ('Christin', '3/2/2024', 'cmcphillipsd@ed.gov');
insert into employee (name, birthday, email) values ('Natalina', '4/26/2024', 'npetegreee@about.me');
insert into employee (name, birthday, email) values ('Delmer', '10/6/2024', 'dlaycockf@devhub.com');
insert into employee (name, birthday, email) values ('Griselda', '8/23/2024', 'gbroadnickeg@smh.com.au');
insert into employee (name, birthday, email) values ('Elston', '10/20/2024', 'ecreboh@e-recht24.de');
insert into employee (name, birthday, email) values ('Audie', '4/5/2024', 'apersiani@skype.com');
insert into employee (name, birthday, email) values ('Evelina', '3/9/2024', 'emccuej@imdb.com');
insert into employee (name, birthday, email) values ('Scott', '11/3/2024', 'sperryk@imdb.com');
insert into employee (name, birthday, email) values ('Maris', '10/15/2024', 'meassoml@npr.org');
insert into employee (name, birthday, email) values ('Astra', '9/26/2024', 'astreetenm@wsj.com');
insert into employee (name, birthday, email) values ('Moshe', '7/6/2024', 'mvannahn@hatena.ne.jp');
insert into employee (name, birthday, email) values ('Willey', '5/20/2024', 'wtworto@joomla.org');
insert into employee (name, birthday, email) values ('Borden', '6/30/2024', 'bfawdreyp@wordpress.org');
insert into employee (name, birthday, email) values ('Artus', '11/2/2024', 'agilliverq@discovery.com');
insert into employee (name, birthday, email) values ('Constantin', '1/4/2025', 'checksr@squarespace.com');
insert into employee (name, birthday, email) values ('Krispin', '3/23/2024', 'kbroadwoods@tuttocitta.it');
insert into employee (name, birthday, email) values ('Joanie', '8/14/2024', 'jhonywillt@hexun.com');
insert into employee (name, birthday, email) values ('Mildrid', '3/2/2024', 'mbezarrau@i2i.jp');
insert into employee (name, birthday, email) values ('Gaston', '9/29/2024', 'gmogerv@t.co');
insert into employee (name, birthday, email) values ('Vilma', '5/11/2024', 'vgrannellw@eepurl.com');
insert into employee (name, birthday, email) values ('Dur', '9/16/2024', 'dmcgeouchx@buzzfeed.com');
insert into employee (name, birthday, email) values ('Currie', '6/21/2024', 'coduggany@loc.gov');
insert into employee (name, birthday, email) values ('Peggie', '9/7/2024', 'pdahlenz@ftc.gov');
insert into employee (name, birthday, email) values ('Simmonds', '7/27/2024', 'sgelling10@linkedin.com');
insert into employee (name, birthday, email) values ('Mohandis', '4/29/2024', 'mhuish11@nyu.edu');
insert into employee (name, birthday, email) values ('Morse', '11/17/2024', 'mlidgerton12@redcross.org');
insert into employee (name, birthday, email) values ('Brigit', '5/1/2024', 'btalks13@com.com');
insert into employee (name, birthday, email) values ('Dane', '4/16/2024', 'dtwinbourne14@webmd.com');
insert into employee (name, birthday, email) values ('Elisabet', '2/17/2024', 'ebriereton15@infoseek.co.jp');
insert into employee (name, birthday, email) values ('Jo-anne', '9/25/2024', 'jnovkovic16@soundcloud.com');
insert into employee (name, birthday, email) values ('Aeriela', '11/13/2024', 'arostron17@yolasite.com');
insert into employee (name, birthday, email) values ('Billie', '3/11/2024', 'bsainsberry18@ed.gov');
insert into employee (name, birthday, email) values ('L;urette', '6/7/2024', 'lcolecrough19@oakley.com');
insert into employee (name, birthday, email) values ('Roxi', '9/20/2024', 'raves1a@forbes.com');
insert into employee (name, birthday, email) values ('Shae', '12/17/2024', 'skirsz1b@histats.com');
insert into employee (name, birthday, email) values ('Claire', '4/28/2024', 'cglancey1c@apache.org');
insert into employee (name, birthday, email) values ('Ronnica', '3/13/2024', 'rgronowe1d@qq.com');

--3.madde
update employee set name = 'Mehmet', birthday = '2010-11-08', email = 'mehmet@gmail.com' where id = 5
update employee set name = 'Mehmet', birthday = '2010-11-08', email = 'mehmet@gmail.com' where id = 5
update employee set name = 'Mehmet', birthday = '2010-11-08', email = 'mehmet@gmail.com' where id = 5
update employee set name = 'Mehmet', birthday = '2010-11-08', email = 'mehmet@gmail.com' where id = 5
update employee set name = 'Mehmet', birthday = '2010-11-08', email = 'mehmet@gmail.com' where id = 5

--4.madde
delete from employee where name = 'Mehmet'
delete from employee where name = 'Mehmet'
delete from employee where name = 'Mehmet'
delete from employee where name = 'Mehmet'