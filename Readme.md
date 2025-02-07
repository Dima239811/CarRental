# Разработка информационной системы для аренды автомобилей

В рамках учебного проекта было разработано приложение для аренды автомобилей с применением объектно-ориентированного подхода программирования.
<br> <br>**Цель проекта:** автоматизировать бизнес-процессы в области аренды автомобилей. 
<br>Программный продукт позволит сотруднику фирмы добавлять и удалять клиентов и автомобили в системе, заключать или расторгать аренды. Также будет разработан пользовательский интерфейс, помогающий взаимодействовать пользователю с системой. Для хранения информации будет использована база данных.

<br> Для создания проекта и представления данных было выбрано приложение с графическим интерфейсом пользователя Windows Forms. 
<br> В работе будут реализованы:
* Главная форма, с которой можно будет перейти на любую другую форму
* Формы для добавления данных (машина, клиент, аренда)
* Формы для удаления данных (машина, клиент, аренда)
* Формы просмотра данных (машины, свободные машины, клиенты и 
аренды)

Для сохранения информации о фирме используется SQL Server Express LocalDB.

## Модель предметной области
![модель](images/Модель%20предметной%20области%20ИС.png)

##  CRC карточки классов системы
![](images/crc1.png)
![](images/crc2.png)
![](images/crc3.png)

## Диаграмма классов системы
### Основная диаграмма классов системы
![](images/диаграмма%20основных%20классов.png)
### Диаграмма классов форм
![](images/Диаграмма%20форм.png)

##  Взаимодействие объектов
### Диаграмма последовательности добавления клиента
![](images/Диаграмма%20последовательности%20добавления%20клиента.png)
### Диаграмма последовательности удаления клиента
![](images/Диаграмма%20последовательности%20удаления%20клиента.png)

## Диаграмма деятельности
### Диаграмма деятельности добавления аренды
![](images/Диаграмма%20деятельности%20добавления%20аренды.png)

## Модель данных
![](images/Диаграмма%20таблиц.png)

## Разработка тестов
Для проверки правильности работы программы были разработаны модульные тесты, результат их выполнения представлен на рисунке. <br>
![](images/результат%20работы%20тестов.PNG)

Для проверки правильности работы контроллеров с БД разработаны тест кейсы.

### Тест-кейсы добавления и изменения статуса автомобиля в БД
![](images/case1.PNG)

### Тест-кейсы получения последнего добавленного клиента и всех клиентов из БД
![](images/case2.PNG)


## Интерфейс приложения
Чтобы начать работать с приложением необходимо его запустить. После чего автоматически загрузится главная форма. <br> Главная форма представляет собой навигацию для пользователя, он может выбрать необходимый ему раздел. Чтобы выйти из приложения,необходимо нажать крестик. <br>
![](images/main_form.PNG)

Для того чтобы посмотреть все автомобили, необходимо на главной форме нажать на кнопку «показать все авто». <br>
![](images/all_cars.PNG)

Чтобы добавить или удалить машины из системы, необходимо нажать на соответствующие кнопки. Формы добавление и удаления авто представлены на рисунке. <br>
![](images/add_car.PNG)

Чтобы просмотреть все доступные автомобили (автомобили, которые не задействованы в аренде), пользователю необходимо на главной форме нажать на кнопку «показать свободные авто». <br>
![](images/all_availiable_cars.PNG)

Аналогично пользователь может нажать на главной форме на кнопку «показать всех клиентов», после чего откроется форма «Все клиенты» <br>
![](images/all_client.PNG)

Добавление и удаление клиента происходит аналогично добавлению и удалению машины. 
<br> Если на главной форме нажать на кнопку «показать все аренды», то открывается форма со всеми арендами <br>
![](images/all_rental.PNG)
 <br>Удаление аренды происходит аналогично удалению машины. <br>

Чтобы добавить новую аренду, пользователь нажимает на форме «Все аренды» кнопку «Добавить новую аренду». После чего появляется форма «Добавление аренды». <br>

Чтобы к аренде добавить клиента, пользователь должен выбрать: есть ли текущий клиент в системе. Если клиент уже занесен в систему, пользователь нажимает на кнопку «Да», вводит его id и нажимает на кнопку «Найти» (в случае если клиент не найдется, появится всплывающее окно, на котором будет написано, что такого клиента в системе нет). Если клиента нет в системе пользователь нажимает на кнопку «Нет», после чего появится форма «Добавления клиента». <br>

Аналогичным образом пользователь к аренде добавляет автомобиль. <br>

Затем пользователь может выбрать с помощью checkbox возможные дополнительные услуги (если пользователь как-то взаимодействует с checkbox, это сразу повлияет на стоимость автоматически, никаких дополнительных кнопок не надо нажимать). <br>

После чего пользователь выбирает сроки аренды автомобиля: дату начала и конца аренды. Чтобы подтвердить выбранные даты, пользователь нажимает на кнопку «Выбрать». Если дата конца аренды окажется более ранней, чем дата начала, то появится модальное окно, которое оповестит пользователя об этом. В случае корректного заполнения даты, выбранные даты прикрепятся к аренде. <br>

После того как пользователь выберет дату и машину, он может рассчитать стоимость (дополнительные услуги также будут учтены), для расчета текущей стоимости пользователю необходимо нажать на кнопку «Рассчитать стоимость». Если пользователю потребуется, он может поменять дату или машину, и снова рассчитать стоимость. <br>

После успешного заполнения автомобиля, клиента и даты, можно добавить аренду, для этого надо нажать на кнопку «Добавить аренду». <br>

### Форма "Добавления аренды"
![](images/add_rental.PNG)


## Результаты проекта
Разработанная система предлагает следующие функциональные 
возможности: <br>
- Добавление/удаление автомобилей
- Просмотр списка всех автомобилей
- Просмотр списка всех доступных автомобилей
- Добавление/удаление клиентов
- Просмотр списка всех клиентов
- Добавление/удаление аренды
- Поиск клиента и машины в системе при заключении аренды
- Возможность выбора предложенных доп. услуг при заключении аренды
- Просмотр списка всех аренд
- Хранение информации в БД о клиентах, машинах и арендах
- Расчет стоимости аренды с учетом выбранной машины, срока аренды и выбранных доп. услуг


---
Автор проекта: **Чекалин Дмитрий**
<br>Обратная связь:
* почта: dimacekalin2311@yandex.ru
* тг: @Dimaaeae
