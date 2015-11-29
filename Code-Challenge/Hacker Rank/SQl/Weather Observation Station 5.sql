//https://www.hackerrank.com/challenges/weather-observation-station-5/submissions/database/15458041
select city, length(city) as mlen from station order by mlen desc, city limit 1; 
select city, length(city) as mlen from station order by mlen asc, city limit 1;