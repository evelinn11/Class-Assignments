use premier_league;

-- no 1
SELECT m.manager_name as 'Nama Manager', if(working = 0, 'Available', concat(t.team_name, ' ,', t.city)) as 'Kesanggupan' 
FROM manager m 
LEFT JOIN team t ON m.manager_id = t.manager_id or m.manager_id = t.assmanager_id;

-- no 2
SELECT m.manager_name as 'Nama Manager', if (m.working = 0, concat('(', n.nation, ')'), 
	concat('Stadium ', t.home_stadium, ' (', t.city, ')')) as 'Alamat' 
FROM manager m 
LEFT JOIN nationality n ON m.nationality_id = n.nationality_id 
LEFT JOIN team t ON t.manager_id = m.manager_id OR t.assmanager_id = m.manager_id;

-- no 3
SELECT t.team_name as 'Team Name', concat(t.home_stadium, ' (', t.capacity, ')') as 'Stadium and Capacity', 
	t.city as 'City', m1.manager_name as 'Manager Name', ifnull(m2.manager_name, '---------') as 'Assistant Manager' 
FROM team t 
LEFT JOIN manager m1 ON m1.manager_id = t.manager_id 
LEFT JOIN manager m2 ON m2.manager_id = t.assmanager_id;

-- no 4
SELECT m.match_date as 'Tanggal Pertandingan', concat(t1.team_name, ' vs ', t2.team_name) as 'Pertandingan', 
	concat(m.goal_home, ' - ', m.goal_away) as 'Hasil Akhir', if(m.goal_home = m.goal_away, 'Draw', 
    if(m.goal_home > m.goal_away, concat(t1.team_name, ' win'), concat(t2.team_name, ' win'))) as 'Kesimpulan' 
FROM `match` m 
JOIN team t1 ON t1.team_id = m.team_home 
JOIN team t2 on m.team_away = t2.team_id;

-- no 5
SELECT t.team_name as 'Nama Team', 
	if(t.assmanager_id is null, m1.manager_name, concat(m1.manager_name, ' & ', m2.manager_name)) as 'Manager & Asisten Manager', 
	p.player_name as 'Nama Captain' 
FROM team t JOIN player p ON p.player_id = t.captain_id 
LEFT JOIN manager m1 ON m1.manager_id = t.manager_id 
LEFT JOIN manager m2 ON m2.manager_id = t.assmanager_id;