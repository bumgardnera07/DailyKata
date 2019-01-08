/* https://www.codewars.com/kata/580918e24a85b05ad000010c */

SELECT people.id, people.name, count(toys.id) as toy_count from people left join toys on people.id = toys.people_id group by people.id order by people.id;

/* Test Cases in RUBY

results = run_sql

describe :items do
   it "should return 2 items" do
    expect(results.count).to eq 2
   end
   
   it "should return names" do
     results.each do |result|
       expect(result[:name]).to eq find_record(:people, result[:id]).name
     end
   end
   
   it "should return toy count" do
    results.each do |result|
      toys = find_records_by_people_id(:toys, result[:id])
      expect(result[:toy_count]).to eq toys.count
    end
   end
end

*/