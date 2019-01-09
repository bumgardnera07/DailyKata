/*https://www.codewars.com/kata/5811527d9d278b242f000006*/

CREATE VIEW members_approved_for_voucher AS
SELECT mem.id, mem.name, mem.email, sum(price) AS total_spending
FROM sales s INNER JOIN ( 
   SELECT sum(price), d.id
   FROM sales s INNER JOIN departments d
   ON s.department_id = d.id
   INNER JOIN products pr 
   ON s.product_id = pr.id
   GROUP BY d.id
   HAVING sum(price) > 10000) dep
  ON s.department_id = dep.id
  INNER JOIN products prod 
  ON s.product_id = prod.id
  INNER JOIN members mem
  ON s.member_id = mem.id
GROUP BY mem.id
HAVING sum(price) > 1000 
ORDER BY mem.id;

SELECT *
FROM members_approved_for_voucher;


/* TEST CASES in RUBY
compare_with expected do
  spec do
    it "should contain CREATE" do
      expect($sql.upcase).to include("CREATE")
    end
  
    it "should contain VIEW" do
      expect($sql.upcase).to include("VIEW")
    end
    
    it "should contain MEMBERS_APPROVED_FOR_VOUCHER" do
      expect($sql.upcase).to include("MEMBERS_APPROVED_FOR_VOUCHER")
    end
  end
  spec "id" do
    it "should be included within results" do
        expect(results.first.keys).to include(:id)
    end
    it "should be a Fixnum value" do
        expect(results.first.keys).to be_kind_of(:Fixnum)
    end
  end
end
*/