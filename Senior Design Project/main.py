import zen
import json
import os

#grab test data from resources folder
TEST_DATA = os.path.join('res', 'Employee_Test_Data.json') 
RULES = os.path.join('Testing', 'RulesTest.json')

#use the generated rules
with open(RULES, "r") as f:
  content = f.read()

engine = zen.ZenEngine()

decision = engine.create_decision(content)

result = [] # create result array
# open file with context manager
with open(TEST_DATA, "r") as data:
    
    data = json.load(data) #load the data as a json array

    for obj in data: # for each object in the array
      result.append(decision.evaluate(obj))

# open context manager, write decisions to a file
with open('output.json', 'w') as f:
    json.dump(result, f, indent=1)
