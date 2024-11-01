SELECT * FROM database_challenge.`employee file`;

-- checking for duplicates
SELECT  'first name', 'last name',	gender,	email,	age,	birthday,	active,	street,	postal,	province,	city,	longitude,	latitude,	package,	vendor,	phone,	package, 'cost',	'contract start',	'contract end', COUNT(email)
from database_challenge.`employee file`
group by 'first name', 'last name',	gender,	email,	age,	birthday,	active,	street,	postal,	province,	city,	longitude,	latitude,	package,	vendor,	phone,	package, 'cost',	'contract start',	'contract end'
having count(email) > 1;



UPDATE database_challenge.`employee file`
SET email = CONCAT(SUBSTRING_INDEX(email, '@', 1), '@company.', SUBSTRING_INDEX(email, '.', -1))
WHERE email LIKE '%@%';

-- linking cell c table
SELECT *
from database_challenge.`employee file`
left join database_challenge.`cell c event detail`
on `employee file`.phone = `cell c event detail`.phone;

-- linning mtn table
SELECT *
from database_challenge.`employee file`
left join database_challenge.`mtn event detail`
on `employee file`.phone = `mtn event detail`.phone;

-- linking vodacom table
SELECT *
from database_challenge.`employee file`
left join database_challenge.`vodacom event detail`
on `employee file`.phone = `vodacom event detail`.phone;