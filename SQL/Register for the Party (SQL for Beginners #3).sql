/* https://www.codewars.com/kata/590cc86f7557c0494000007e */

INSERT Into participants VALUES ('johnjacobjingleheimerschmidt', '120', 'true');

SELECT * FROM participants;

/* Test Cases in Ruby

# Run SQL
results = run_sql

# Tests
describe :participants do
   it "should return 3 participants" do
    expect(results.count).to eq 3
   end
end */