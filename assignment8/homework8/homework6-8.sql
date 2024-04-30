
drop database if exists `orderApp`;
create database  `orderApp`;
use orderApp;

drop table if exists `good`;
create table `good`(
`goodId` int(8) not null auto_increment,
`goodName` varchar(10)default null,
`price` float(4),
primary key (`goodId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

drop table if exists `customer`;
create table `customer`(
`customerId` int(8)not null auto_increment,
`customerName` varchar(10) default null,
primary key(`customerId`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

drop table if exists `order`;
create table `order`(
`id` int(8) not null auto_increment,
`createTime` datetime,
`price` float(4),
`customerId`int(8),
foreign key (`customerId`) references `customer`(`customerId`) on delete cascade,
/*foreign key (`customerName`) references `customer`(`customerName`) on delete cascade,*/
primary key(`id`)
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

drop table if exists `orderDetail`;
create table `orderDetail`(
`id` int(8) not null auto_increment,
`createTime` datetime,
`goodId` int(8),
foreign key(`goodId`) references `good`(`goodId`)on delete cascade,
`quantity` int(2) default null,
`price` float(4),
foreign key(`id`) references `order`(`id`)on delete cascade
)ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;


