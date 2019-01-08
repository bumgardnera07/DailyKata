/*https://www.codewars.com/kata/582cb0224e56e068d800003c*/

SELECT id, hours, FLOOR((0.5)*hours) as liters FROM cycling

/* Test Cases in Ruby

DB.create_table :cycling do
  primary_key :id
  Float :hours
end

items = DB[:cycling] # Create a dataset

# Populate the table
5.times do
  num= Faker::Commerce.price
  items.insert(hours:  num)
end

describe :columns do
   it "should return 3 columns" do
    expect(results.columns.count).to eq 3
   end
end

describe :column_names do
   it "should match column names" do
    expect(results.columns[0].to_s).to eq "id"
    expect(results.columns[1].to_s).to eq "hours"
    expect(results.columns[2].to_s).to eq "liters"
   end
end
