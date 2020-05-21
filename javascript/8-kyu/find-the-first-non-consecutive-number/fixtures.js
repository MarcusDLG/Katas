Test.describe('a simple example', function() {
  const first = firstNonConsecutive([1,2,3,4,6,7,8])
  Test.assertEquals(first, 6)
})