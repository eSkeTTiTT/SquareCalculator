create table products (
	id int primary key,
	name text
);

create table categories (
	id int primary key,
	name text
);

create table product_categories (
	product_id int foreign key references products(id),
	category_id int foreign key references categories(id),
	primary key (product_id, category_id)
);

select p.name, c.name
from products p
left join product_categories pc
	on p.id = pc.product_id
left join categories c
	on c.id = pc.category_id