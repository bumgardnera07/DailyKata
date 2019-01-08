/* https://www.codewars.com/kata/591127cbe8b9fb05bd00004b */

SELECT Top 5 * from books order by copies_sold DESC;

/* Test Cases in Ruby

# Run SQL
results = run_sql

# Tests
describe :books do
   it "should return 5 books" do
    expect(results.count).to eq 5
   end
end
*/