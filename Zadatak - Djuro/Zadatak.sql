use Veverica

select * from vProizvodjac

select ProizvodjacID as 'Redni Broj', Naziv, Adresa, MaticniBroj, BrojRadnika, Budzet, NazivNaselja
from Proizvodjac left join Naselje on
Proizvodjac.NaseljeID = Naselje.NaseljeID


declare @id int
set @id = (select max(ProizvodjacID) + 1 from Proizvodjac)

insert into Proizvodjac
values(@id, 'Sloboda', 'Tanaska Rajica 9', 14879663, 150, 45000, 3)


select * from Proizvodjac
delete Proizvodjac
where MaticniBroj = 9875462


update Proizvodjac
set BrojRadnika = 210, Budzet = 97000
where Naziv like 'Lev9'


declare	@donji int
declare @gornji int
set @donji = 50000
set @gornji = 1000000

select * from Proizvodjac
where Budzet between @donji and @gornji
