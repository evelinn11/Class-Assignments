use premier_league;

-- no 1
select t.team_name as 'Nama Team', count(d.type) as 'Jumlah Goal' 
from team t join dmatch d on d.team_id = t.team_id 
where d.type = 'GO' or d.type = 'GP' 
group by t.team_id 
order by 2 desc;

-- no 2
select t.team_name as 'Nama Team', count(d.type) as 'Jumlah Goal' 
from team t 
join dmatch d on d.team_id = t.team_id 
where d.type = 'GP' 
group by t.team_id 
order by 2 desc;

-- no 3
select `minute` as 'Minute', count(type) as 'Jumlah Goal'
from dmatch 
where type = 'GO' or type = 'GP' 
group by `minute` 
order by 2 desc;

-- no 4
select n.nation as 'Nationality', count(p.player_id) as 'Jumlah Pemain' 
from nationality n, player p 
where p.nationality_id = n.nationality_id 
group by 1 
having count(player_id) < 4 
order by 2 desc;

-- no 5
select p.player_name as 'Nama Pemain', count(d.type) as 'Jumlah Gol' 
from player p, dmatch d 
where p.player_id = d.player_id and p.team_number < 6 and (d.type = 'GO' or d.type = 'GP') 
group by p.player_id;

