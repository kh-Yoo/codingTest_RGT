import json
import threading
import time
from datetime import datetime, timedelta
from xml.etree import ElementTree
import requests
from pystray import MenuItem as item
import pystray
from PIL import Image
index = 1
while True:
    url = "http://211.44.24.167:51231/navi/info"
    url = requests.get(url)
    text = url.text
    print(type(text))
    data = json.loads(text)
    print(type(data))
    print("=============")
    print(data["status"])
    print("=============")
    def action():
       pass

    image = Image.open("/Users/yuganghyeon/Desktop/image.jpg")
    menu = (item('index : ' + str(index), action), item('status :' + str(data["status"]), action), item('확인', action))
    icon = pystray.Icon("name", image, "title", menu)
    icon.run()
    print(type(data["status"]))
    if data["status"] == 3:
        url2 = "http://211.44.24.167:51231/navi/forced"
        url2 = requests.get(url2)
        text2 = url2.text
        print(text2)
    time.sleep(3)
    index += 1