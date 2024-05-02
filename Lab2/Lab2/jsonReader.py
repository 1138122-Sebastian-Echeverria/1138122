import json

def readJsonFile():
    data = [] 
    with open(r'C:\Users\Virtu\Documents\Github\1138122\input_challenge_lab_2.jsonl') as jsonFile:
        for line in jsonFile:
            data.append(json.loads(line))
    return data
