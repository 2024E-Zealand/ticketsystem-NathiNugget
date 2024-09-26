from socket import * 
import json


serverName = "localhost"
serverPort = 728

clientSocket = socket(AF_INET, SOCK_STREAM) # Stream: TCP, DRAM: UDP
clientSocket.connect( (serverName, serverPort))

def SendPrompt(jsonForServer):
    jsonForServer += "\r\n"
    clientSocket.send(jsonForServer.encode())
    returnSentence = clientSocket.recv(1024)
    print(returnSentence.decode())
    


#læser input fra skærm/tastatur
class Command:
    def __init__(self, command, num1, num2):
        self.Method = command
        self.Num1 = num1
        self.Num2 = num2


c1 = Command("Random", 1, 10)
c2 = Command("Subtract", 1, 2)
c3 = Command("Add", 1, 2)

SendPrompt(json.dumps(c1.__dict__))
SendPrompt(json.dumps(c2.__dict__))
SendPrompt(json.dumps(c3.__dict__))

clientSocket.close() 