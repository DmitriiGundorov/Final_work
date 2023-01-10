# Final_work
Задача: Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


# Инструкция для работы с Git и удалёнными репозиториями
===========================================

***Git*** - это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории. Является самой популярной реализацией систем контроля версий в мире.

## Настройка Git'а
 
 Для начала работ с Git'ом необходимо установить имя пользователя

**git config --global user.name "Dmitrii Gundorov"**

Затем необходимо установить email
**git config --global user.email "gundorov1987@yandex.ru"**

## Команды

1. **git init** - инициализация (создание) локального репозитория в папке с репозиторием (появится скрытая папка .git)
2. **git add** - добавление измений в коммит (*git add <имя файла>*)
3. **git commit** - создание коммита (сохранение, фиксирование). 
- *git commit -m "<сообщение к коммиту>* - создание коммита 
- *git commit -am "<сообщение к коммиту>* - создание коммита с внесением изменений (одновременное выполнение команды add и commit). Работает только при модифицированном состоянии файла
4. **git status** - команда для просмотра состояния репозитория (просмотр изменений в файлах)
5. **git checkout** - перемещение между коммитами.
- *git checkout <номер коммита>* - перемещение к указанному коммиту
- *git checkout -b <название ветки>* - создание и переход на созданную ветку
1. **git log** - просмотр всех сделанных изменений.
* *git log* - просмотр списка коммитов
* *git log --graph* - просмотр коммитов с графическим отображением веток в папке с репозиторием
* *git log --oneline* - краткая информация по всем коммитам в виде списка
7. **git branch** - создание новых веток. Выполняется в папке с репозиторием: *git branch <название новой ветки>*
8. **git merge** - слияние веток с сохранением параллельной родительской историей: 
- *git merge <name branch>* - добавление указанной ветки в текущую;
- *git merge --abort* - отмена слияния веток
9.  **git rebase <name branch>** - слияние веток с переносом родительских коммитов в коммиты ветки слияния (последовательные коммиты)
10. **git branch -d 'name branch'** - удаление указанной ветки
11. **git diff** - просмотр отличий между текущим файлом и закоммиченным
- *git diff* - разница между рабочей директорией и индексом;
- *git diff --staged* - разница между индексом и последним коммитом;
- *git diff master branchB* - разница между коммитами
12. **git rm** - используется для удаления файлов из индекса и рабочей директории (команда противоположная *git add*)
13. **git mv** — удобный способ переместить файл, затем выполняется *git add* для нового файла и *git rm* для старого
14. **git clean** - удаление мусора из рабочей директории (результаты сборки проекта или файлы конфликтов слияний)
15. **git tag** - используется для задания постоянной метки на какой-либо момент в истории проекта. Обычно используется для релизов
16. ****git fetch** - связывается с удалённым репозиторием и забирает из него все изменения, которых пока нет и сохраняет их локально
17. **git pull** - работает как комбинация команд *git fetch* и *git merge*, т.е. вначале забирает изменения из указанного удалённого репозитория, а затем пытается слить их с текущей веткой
18. **git push** - используется для установления связи с удалённым репозиторием, вычисления локальных изменений отсутствующих в нём, и собственно их передачи в вышеупомянутый репозиторий
- **git push -u origin <имя ветки>** - запись указанной ветки в репозиторий
19. **git archive** - используется для упаковки в архив указанных коммитов или всего репозитория
20. **git show** - отображает объект в простом и человекопонятном виде. Обычно используется для просмотра информации о метке или коммите
21. **git shortlog** - служит для подведения итогов команды *git log*. В отличии от *git log* коммиты группируются по автору
22. **git bisect** — предназначена для поиска коммита в котором впервые проявился баг или проблема с помощью автоматического бинарного поиска
23. **touch** <имя файла с расширением> - команда создания файла в данной директории
24. **echo** "тест, передаваемый в файл" > <имя файла с расширением> - добавление информации в указанный файл
25. **mkdir** <название папки> - создание папки в текущей директории
26. **cd** - перемещение по директории
- **cd** <название папки> - переход в указанную папку
- **cd** .. - выход из текущей папки
- **cd** ~ - выход из папок
27. **cat** <имя файла> - проверка состава файла.

### Основные команды Git'a
![Основные команды Git'a](ComandsGit.jpeg)


**Полезные ссылки по GIT** 

* [Ссылка 1 - Git для новичков (часть 1)](https://habr.com/ru/post/541258/) 

* [Ссылка 2 - Git для новичков (часть 2)](https://habr.com/ru/post/542616/) 

* [Ссылка 3 - Книга. Git профессионального программиста ](https://gbcdn.mrgcdn.ru/uploads/asset/4245110/attachment/d4eb8c232f8f2bdf4e42ba7cb49e0c50.pdf) 

* [Ссылка 4 - Шпаргалка по Git ](https://training.github.com/downloads/ru/github-git-cheat-sheet/) 

* [Ссылка 5 - GIT: фишки и возможности ](https://netology-code.github.io/guides/git-links/#articles)

* [Ссылка 6 - GIT: обучение, видео ](https://vimeo.com/showcase/5616060)

* [Ссылка 7 - GIT: обучение, прохождение курсов ](https://learngitbranching.js.org/?locale=ru_RU)