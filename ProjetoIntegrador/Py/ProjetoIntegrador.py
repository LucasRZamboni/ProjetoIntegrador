import pyautogui as py
import pandas as pd
import time
import pyperclip as clip
from datetime import date

from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By

# 1 - abrir o chrome
navegador = webdriver.Chrome(executable_path=r'./chromedriver.exe')
#   1.1 - maximizar tela
navegador.maximize_window()
# 2 - digitar o site do mapa       
navegador.get("http://terrabrasilis.dpi.inpe.br/app/map/deforestation")
#   2.1 - clicar em não mostre novamente
navegador.find_element("xpath",'//*[@id="notice"]').click()
#   2.2 - fechar não mostre novamente
navegador.find_element("xpath",'//*[@id="firstNotice"]/div/div/div[1]/button/i').click()
# 3 - Clicar em pesquisar localização
navegador.find_element("xpath",'//*[@id="map"]/div[2]/div[1]/div[4]/input').click()
