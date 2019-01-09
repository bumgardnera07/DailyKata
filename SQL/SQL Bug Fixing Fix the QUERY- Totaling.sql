/* https://www.codewars.com/kata/582cba7d3be8ce3a8300007c */

SELECT 
  s.transaction_date::date as day,
  d.name as department,
  COUNT(s.id) as sale_count
  FROM department d
    Join sale s on d.id = s.department_id
  group by day, d.name
  order by day asc, name asc



/* Test Cases  in RUBY

compare_with expected do
    draw_chart(
      type: :timeseries, 
      group_by: :department,
      x: :day,
      y: :sale_count,
      sort: false
    )
end


*/