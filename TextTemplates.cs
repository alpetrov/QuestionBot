﻿using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QUESTionBot
{
    static class TextTemplates
    {
        public static string message1 = "Привет! Меня зовут Q, я - Telegram-бот. " +
            "\n\nСегодня я буду вашим помощником. Сейчас начнется ваш маршрут. " +
            "Впереди еще много интересных и загадочных мест Петроградской стороны. " +
            "Несмотря на то, что историческим центром Санкт-Петербурга является его левобережная часть, именно на Петроградской стороне были заложены первые постройки города: " +
            "Петропавловская крепость на Заячьем острове, Дом Петра I, Троицкая площадь, " +
            "где располагался первый торговый порт, здесь же в 1721 году Петр I принял титул императора. " +
            "\nМы уверены, что вы уже успели посмотреть все основные достопримечательности Петроградской стороны, " +
            "но сегодня вы узнаете то, что не расскажут учебники истории. ";

        public static string message2 = "Правила QUESTion:" +
            "\n1. Баллы за правильные ответы на вопросы суммируются и учитываются при подсчете результатов команды. За правильное выполнение задания с вариантами ответов дается 1 балл, за задания повышенной сложности - от 2 до 5." +
            "\n2. Время прохождения полного маршрута учитывается при подсчете результатов команды;" +
            "\n3. На каждой станции маршрута будет определен свой таймер - время, за которое ваша команда должна успеть выполнить задание;" +
            "\n4. Для того, чтобы приступить к основному заданию на станции, необходимо выполнить предварительное задание для того, чтобы организаторы удостоверились, что команда достигла пункта назначения;" +
            "\n5. При выполнении некоторых заданий можно воспользоваться подсказкой, для этого появится специальная кнопка. Заметьте, если вы пользуетесь подсказкой, то теряете 1 балл." +
            "\n6. При возникновении трудностей, вопросов и спорных ситуаций пишите @katchern" +
            "\n7. Капитан несет ответственность за соблюдение правил ПДД всеми членами команды" +
            "\n\nНажимая на кнопку \"согласен/согласна\", капитан даёт своё согласие с правилами квеста и согласие на соблюдение правил ПДД.";

        public static string message3 = "Обращайте внимание на сообщения, которые я вам буду присылать, они могут помочь при решении некоторых задач"
            + "\nВыкладывайте фотографии команды, отмечайте @itmo.students, ставьте хэштег #QUESTion и получайте +2 балла. Не забудьте указать название своей команды!";

        public static string message4 = "*Желаем вам приятной прогулки!*";

        public static string message5 = "Для старта маршрута введите, пожалуйста, код:";

        public static string message7 = "Сад Андрея Петрова был разбит в 2005 году в знак протеста местных жителей против застройки этой территории " +
            "Каменноостровского проспекта. Они попросили известных личностей посадить по дереву в этом саду, среди этих людей и был композитор Андрей Петров.";

        public static string message8 = "Андрей Павлович Петров (1930-2006) - композитор и общественный деятель. " +
            "Творчество композитора очень многообразно. Ему принадлежат как популярные мелодии к кинофильмам " +
            "(“Служебный роман”, “Берегись автомобиля”, “Человек-амфибия”), музыка к песням и романсам, так и произведения серьезной " +
            "(академической) музыки — балеты, оперы, симфонии, инструментальные концерты.";

        public static string answer9 = "В скульптурную коллекцию «Первая скрипка» входит восемь скульптур - художественных символов миссии Композитора:" +
            "\n1. «Скрипка-Яблоко» как символ искушения музыкой;" +
            "\n2. «Скрипка-Туфелька» - символ музыкального эксперимента;" +
            "\n3. «Скрипка-Женщина» («Муза композитора») - символ вдохновения;" +
            "\n4. «Скрипка-Кресло» («Трон Композитора») - символ музыкальной паузы;" +
            "\n5. «Скрипка-Лебедь» («Реквием») - символ музыкального совершенства;" +
            "\n6. «Скрипка-Граммофон» - символ музыкальной классики;" +
            "\n7-8. Две идентичные скульптуры «Скрипка-Сфинкс» - символ охраны музыкального наследия.";

        public static string message11 = "Слева от входа в Сад, на стене дома №28 по Каменноостровскому проспекту можно увидеть Стену столетий." +
            " Она создана известным Петербургским художником Кириллом Миллером как память о череде столетних юбилеев великих деятелей культуры. " +
            "Для того, чтобы приступить к заданию, необходимо найти Стену столетий и написать фамилию деятеля, которому установлено целых 2 памятных знака (Только фамилию!)";

        public static string message12 = "Даниил Хармс (1905-1942) - советский писатель, поэт и драматург. Долгое время проживал в  Петербурге на улице Маяковской. " +
            "Не раз был арестован за чтение запрещенной в то время литературы. " +
            "Прежде всего известен читателям как автор литературы для детей. Хотя, сам писатель утверждал, что детей не любит. " +
            "Человек-абсурд, гений бреда и мастер эпатажа - это про Хармса.";

        public static string message13 = "Кстати, он очень любил маленьких собак, которые подчеркивали его высокий рост. Он давал им необычные имена, и эти клички постоянно менялись." +
            " Например, одну собаку звали «Бранденбургский концерт».";

        public static string message14 = "Предположите, а какое сокращенное имя было у собаки с именем «Чти память дня сражения при Фермопилах»? " +
            "_За это задание вы можете получить 2 балла._";

        public static string message16 = "Сальвадор Дали (1904-1989) - испанский живописец, график, скульптор, режиссёр и писатель; " +
            "один из самых известных представителей сюрреализма. Барельеф Дали выполнен в виде двенадцати одинаковых портретов художника, " +
            "расположенных на ромбе по кругу, напоминая своеобразные каменные часы без стрелок.";

        public static string answer17 = "Последняя картина принадлежит Максу Эрнсту, немецко-французскому художнику-сюрреалисту. Она называется “Да здравствует любовь” (1923).";

        public static string answer18 = "Это Chupa-Chups. Дали подготовил логотип за час. Ромашку правильной формы он изобразил на клочке газеты и предложил писать название конфеты внутри цветка. " +
            "На использование цветов художника вдохновил испанский флаг.";

        public static string message19 = "Дмитрий Шостакович (1906-1975) - советский композитор, пианист и педагог. Один из крупнейших композиторов XX века, " +
            "автор 15 симфоний и 15 квартетов, 6 концертов, 3 опер, 3 балетов, многочисленных произведений камерной музыки, музыки для кинофильмов и театральных постановок.";

        public static string message20 = "Седьмая симфония Шостаковича (Ленинградская) – это великое произведение, отражающее не только волю к победе, " +
            "но и непреодолимую силу духа русского народа.";

        public static string message23 = "В 1923—1928 годах обучался в университете в романо-германской и славяно-русской секции отделения языкознания" +
            " и литературы факультета общественных наук. Сейчас это учреждение высшего образования называется «Санкт-Петербургский государственный университет». " +
            "А как оно называлось в те годы?\n1) Императорский Санкт-Петербургский университет\n2) Санкт-Петербургский государственный университет\n3) Петроградский государственный университет";

        public static string answer24 = "Петроградский государственный университет. Наш город менял свое название несколько раз: Санкт-Петербург (1703-1914)," +
            " Петроград (1914-1924), Ленинград (1924-1991) и снова Санкт Петербург (1991- по н.в.). ";

        public static string message25 = "Вы молодцы, первая станция пройдена, но точно не стоит расслабляться! Кстати, интересный факт: с обратной стороны Каменноостровского проспекта раньше располагалась телефонная будка," +
            " с которой главный герой фильма “Брат” Данила звонил девушке Свете, чтобы сообщить о готовящемся для нее сюрпризе\n*ТЕ*";

        public static string message27 = "Вы находитесь во дворе дома Первого Российского страхового общества со стороны Кронверкской улицы, а перед вами -" +
            " уже знакомый композитор Дмитрий Шостакович. Именно в этом доме он начал работу над своей знаменитой симфонией. " +
            "Кстати, премьера в Ленинграде состоялась 9 августа 1942 года. Произведение звучало в каждом доме, на улицах, так как трансляция велась " +
            "по радио и через уличные громкоговорители. Немцы были в изумлении – это был настоящий подвиг.";

        public static string answer30 = "С 1941 года Ольга Берггольц работала на радио, ежедневно обращаясь к мужеству и стойкости горожан. " +
            "Во время блокады не прекращалась и художественная деятельность. Картина Н.И. Дормидонтова «Зарево над Ленинградом».";

        public static string answer31 = "Александр Андреевич Прокофьев (1900-1971) - русский советский поэт и журналист, военный корреспондент, общественный деятель. " +
            "Автор многочисленных стихотворений, ни одна из многочисленных рецензий и статей " +
            "о его стихах не обходится без определений «самобытный», «неповторимый», «своеобразный».";

        public static string message32 = "Не можем обойти стороной и расположенную рядом музей-квартиру,  посвященную памяти первого " +
            "секретаря Ленинградского обкома и горкома партии ВКП Сергею Мироновичу Кирову.";

        public static string message33 = "Он один из известнейших государственных и партийных деятелей советской эпохи 1920–1930-х гг. и ближайших соратников И.В. Сталина. Личность Кирова, благодаря своей харизме и обстоятельством биографии, " +
            "стала одним из символов того времени, стала одним из символов Ленинграда.";

        public static string answer34 = "Биография С. М. Кирова достаточно интересна, но вряд ли он когда-нибудь задумывался о том, чтобы защищать интересы большевиков на Дальнем Востоке";

        public static string message35 = "С.М. Киров входил в состав Российской социал-демократической рабочей партии (РСДРП), лидером которой был Владимир Ильич Ленин. До какого года просуществовала эта партия?";

        public static string message36 = "Думаю, вам очень понравился это дом не только своей разнообразной историей, но и потрясающей архитектурой. " +
            "Дом был спроектирован двумя Бенуа, которые отличились еще несколькими проектами в Петербурге. Идем к следующему дому вместе!";

        public static string message38 = "Мы в так называемом дворе-курдонере (или парадный двор). А еще этот дом называется домом" +
            " трех Бенуа - потому, что его спроектировали три  архитектора с одинаковой фамилией: Леонтий, Юлий и Альберт Бенуа." +
            "А догадаетесь ли вы, кем они друг другу приходились?";

        public static string answer38 = "Архитекторы дома Бенуа - два родных брата и один двоюродный. " +
            "Кстати, это самое знаменитое петербургское здание начала XX века. Когда-то это был самый" +
            " большой жилой комплекс в городе: здание прописано сразу по трем адресам и занимает едва ли не квартал на Петроградской стороне. Здесь 12 дворов!";

        public static string message39 = "Мы уже упомянули, что это дом Первого Российского страхового общества. На фасаде дома можно найти двух" +
            " древнеримских богов, именно они и напоминают об этом обществе." +
            "\nДевушка с колосьями в руке - богиня удачи, а молодой человек рядом, в крылатом " +
            "шлеме и жезлом - бог торговли.Напишите их имена через пробел. _За это задание вы можете получить 2 балла._";

        public static string answer39 = "Эти боги - Фортуна и Меркурий. Ловите следующую геометку и двигайтесь во двор дома. Вы можете пройти по проходной парадной, находящейся под вывеской “Автошкола”. *ХИ*";

        public static string message40 = "Мы перешли в один из внутренних дворов дома. Разница с парадным двором очевидна, не так ли?" +
            "\nТем не менее, в этом доме проживали многие выдающиеся личности своего времени: ученые, художники и музыканты, партийные и государственные деятели.";

        public static string message41 = "В этом доме жили:\n" +
            "Сергей Миронович Киров - революционер и политический деятель.\n" +
            "Михаил Павлович Чехов - писатель, театральный критик. Младший брат и биограф Антона Павловича Чехова.\n" +
            "Матвей Генрихович Манизер — советский, российский скульптор-монументалист. Лауреат трех Сталинских премий.\n" +
            "Владимир Ильич Иоффе - советский микробиолог и иммунолог.\n" +
            "Найдите их портреты во дворах дома, решите ребусы и напишите фамилию человека, с которым ассоциируются эти слова. _За это задание вы можете получить 3 балла._";

        public static string message42 = "Это было не так просто, но теперь вы познакомились с этим поистине уникальным и запутанным двором дома Бенуа. " +
            "Невозможно уместить все, что впитал это дом за свою насыщенную историю, поэтому обязательно посмотрите дополнительные материалы по этому дому." +
            " Поверьте, оно того стоит! А пока мы от нашего дуэлянта и лицеиста движемся к самому лицею. *А*";

        public static string message43 = "Александровский лицей (или Императорский Александровский лицей) — название Царскосельского лицея после переезда из Царского села в Санкт-Петербург." +
            " В русской истории известен, в первую очередь, как образовательное учреждение, воспитывающее А. С. Пушкина.";

        public static string answer44 = "Несмотря на то, что лицей переехал из Царского села в Санкт-Петербург именно по приказу Николая I в 1843 г., бюста императора здесь никогда не было. Ранее перед лицеем " +
            "находился бюст Александра I - ведь именно в честь него было названо учебное заведение. Также здесь находился бюст А. С. Пушкина, позднее - В. И. Ленина. (см. фото)";

        public static string message45 = "Фамилия А. С. Пушкина всегда ассоциируется с дуэлями - в его жизни их было более 20, но бо́льшая часть не состоялась." +
            " Однажды писатель сочинил эпиграмму (небольшое сатирическое стихотворение, высмеивающее какое-либо лицо или общественное явление), " +
            "подшучивая над своим другом, Вильгельмом Кюхельбекером. Последний, в свою очередь, обиделся и вызвал Пушкина на дуэль; тот согласился.";

        public static string message46 = "В назначенное время поединок состоялся. Их общие знакомые до последнего не верили в происходящее: " +
            "молодые люди были друзьями. Неужели один застрелил другого из-за глупого стишка? Кюхельбекер первым нажал на курок. Пуля как будто пролетела мимо. Настал черед Пушкина. Щелчок – и только.";

        public static string answer47 = "Скорее всего, это легенда, но она гласит о том, что пистолеты дуэлянтов были заряжены клюквой." +
            " После этого друзья, конечно же, помирились. Но существует и альтернативная, более вероятная, версия: " +
            "Кюхельбекер действительно промахнулся, а Пушкин стреляться не хотел, поэтому специально уронил пистолет и утверждал, что ствол забился " +
            "снегом и выстрелить тот не может. Дуэль пришлось отложить, а там приятели и помирились.";

        public static string message48 = "У Пушкина было большое количество друзей-поэтов, с которыми они часто обсуждали идеи будущих произведений." +
            "\nКакому писателю А. С.Пушкин подбросил идею знаменитой пьесы?";

        public static string answer48 = "А. С. Пушкин подбросил Гоголю идею пьесы “Ревизор”. В её основу легли реальные события, свидетелем которых поэт стал незадолго до этого.";

        public static string message49 = "Угадайте по описанию, о каком герое романа Пушкина идёт речь?" +
            "\n_Молодой человек в возрасте 17-18 лет, еще до своего рождения был записан свои отцом-дворянином в Семеновский полк. Был воспитан крепостным крестьянином._";

        public static string answer49 = "Образ Петра Гринева, созданный Пушкиным в «Капитанской дочке» — это не просто положительный персонаж. В повести показывается его взросление, закалка нравственных качеств и умение преодолевать трудности.";

        public static string message52 = "Мы находимся на площади Льва Толстого. Здесь расположен знаменитый Дом с башнями, являющейся настоящим украшением площади. В 1895 году между этим зданием и набережной Карповки был построен Каменноостровский велодром. Зимой там располагался Северный каток, на котором 8 марта 1898 года был сыгран первый в России хоккейный матч с мячом. 31 мая того же года на этом же велодроме был проведён первый в России показательный матч по боксу, вошедший в историю российского спорта как первое официальное боксерское состязание. ";

        public static string message53 = "На одной из башен можно увидеть необычный циферблат со знаками Зодиака. ";

        public static string message55 = "Сейчас в этом доме располагается театр “Русская антреприза” имени Андрея Миронова. Посмотрите отрывок известного фильма, где Андрей Миронов сыграл одну из главных ролей." +
            " Напишите название этого фильма. _За это задание вы можете получить 2 балла._";

        public static string message57 = "Посмотрите на старое фото. На месте Дома Мод находится особняк. В середине 1950-х весь участок освободили для строительства нового здания. А что располагалось в этом особняке до его снесения?";

        public static string answer57 = "Этот особняк принадлежал Эрнесту Росту, экипажного дел мастеру. Здесь располагался доходный дом, а потом - туберкулезный диспансер.";

        public static string answer58 = "Это Катерина Ивановна. Героиня умирает в день похорон господина Мармеладова, который погибает, попав пьяным под лошадь. Раскольников, главный герой романа, отдает Катерине Ивановне последние деньги, чтобы та смогла похоронить мужа. Причиной смерти самой героини становится внезапно открывшееся чахоточное кровотечение.";

        public static string message59 = "Кстати, Эрнест Рост управлял Зоосадом в конце XIX века. Зоосад - старое название Ленинградского зоопарка, находящегося практически напротив главного корпуса ИТМО. Зоопарк носит имя Ленинградского в память о страшной блокаде, во времена которой страдали не только люди, но и животные. Не всех из них успели эвакуировать, некоторые были убиты немецкими бомбами, другие были вынужденно застрелены. Клички животных остались в памяти жителей Ленинграда. А вы сможете назвать, кто из этих животных пережил блокаду?";

        public static string message60 = "Первый дом Ленсовета, возведенный в тридцатые годы, предполагался для проживания партийной элиты. Учитывая статус предполагаемых жильцов, планировка дома имела свои особенности. Например, по слухам, для прослушивания практически каждой квартиры имелись специальные комнаты.";

        public static string message61 = "Спустя годы, здание обветшало и требовало ремонта, во время которого рабочие увидели на плитах странные надписи. Как оказалось, в период дефицита материалов при возведении дома использовали надгробия со старинных петербургских кладбищ. На Петроградской стороне их было три, и ни одно к сегодняшнему дню не сохранилось. Плиты были уложены гравировками вниз, поэтому жильцы десятилетиями ходили по ним и ни о чем не догадывались.";

        public static string message62 = "Нынешние жильцы первого дома Ленсовета связывают этот факт с душевным состоянием его обитателей. В период 1940-80 годов здесь наблюдалось несоразмерно большое количество драк и случаев помешательств и самоубийств владельцев квартир.";

        public static string message63 = "_Представим, что вы оказались во дворе этого дома. Вы детективы. В квартире этого дома нашли девушку, которая очень любила красные розы, ведь они хорошо подходили ее сумочке. А вот зеленые розы  она терпеть не могла, так как у нее была аллергия на эти цветы.\n" +
            "Ирония заключается в том, что офицер полиции нашел ее тело именно с букетом зеленых роз.\n" +
            "Известно, что девушка в последнее время контактировала с тремя людьми.\n\n" +
            "Подозреваемый 1\n\n" +
            "Её любовник, который работает флористом и в злополучный вечер был с девушкой. Известно, что она объявила об их расставании у него на работе.\n\n" +
            "Подозреваемый 2\n\n" +
            "Ее муж, который в ту ночь  и обнаружил тело жертвы. Известно, что его жена была на него обижена, так как он отказывался принимать таблетки для зрения. Он хотел подарить ее любимые цветы.\n" +
            "\nПодозреваемый 3\n\n" +
            "Ее брат, который постоянно отправлял своей жене зеленые розы, а сестре красные розы. В тот вечер он случайно перепутал посылки, однако муж утверждает, что жена посылку не открывала._";

        public static string message64 = "Напишите, кто убил жену, и почему. _За это задание вы можете получить 3 балла - 1 балл за убийцу и 2 за причину смерти._";

        public static string message65 = "_*Разгадка*: ее случайно убил муж, потому что перепутал красные розы с зелеными, так как страдал дальтонизмом. Именно поэтому он и принимал таблетки._";

        public static string message68 = "Раньше напротив этого места стояла гостиница “Северная корона”, которая была построена в 1988 году, но она фактически никогда не функционировала. Несколько десятков лет гостиница стояла буквально необитаема, но за время ее существования на территории произошло  около 40 несчастных случаев, последний из которых унес жизнь рабочего в 2019 году.";

        public static string message69 = "Если мы пройдем чуть дальше, то сможем увидеть не менее интересное место. На двух разных берегах реки Карповки располагались два враждующих пламени революции 1917 года.";

        public static string message70 = "С одной стороны женский монастырь Иоанна Кронштадтского. К 1917 году в монастыре проживало 350 сестер. Практически все необходимое сестры делали сами. Обитель имела свое подсобное хозяйство, мастерские, больницу. Оказывалась благотворительная помощь нуждающимся, действовал приют для сирот. Во время Первой мировой войны в монастыре был открыт лазарет для раненых солдат и офицеров." +
            "\nСам преподобный Иоанн прославился тем, что отдавал все свои деньги нищим. Впоследствии он стал важной фигурой в истории русского православия. В 1894 году Иоанн Кронштадтский присутствовал при постели умирающего императора Александра III, причастил его. В начале XX века святой предрек революционные события, а в дневнике, размышляя, писал, что нынешние шатания – из-за утери веры в Бога.";

        public static string message71 = "С другой стороны берега находится дом, в котором 23 октября 1917 года произошло историческое заседание большевиков, в ходе которого было принято решение о государственном перевороте." +
            "\nНа том заседании присутствовали: И.В. Сталин, В. И. Ленин, С. К. Орджоникидзе, Л. Д. Троцкий, М. С. Урицкий, Г. Е. Зиновьев, А.С. Бубнов, Л. Б. Каменев.";

        public static string message72 = "Вы сейчас находитесь в таком интересном месте, которое аккумулирует вокруг себя достаточно неоднородную и мистическую энергию прошлых лет. Для вас есть не менее интересное задание\n" +
            "Представьте, что во времена Ленина и Сталина существовал бы TikTok, какой бы челленж они сняли? Присылайте ответы @nai\\_bogdan . Не забудьте указать название команды!\n" +
            "Мы оцениваем не развернутость истории, а ее креативность. _За это задание вы можете получить 5 баллов._";

        public static string message74 = "Санкт-Петербург часто называют музеем под открытым небом. Но не все достопримечательности города сохранились. Перед вами - особняк Эрнеста Игеля. Как видно, здание покрыто зелёной сеткой, а вокруг него можно найти части обвалившегося фасада. Внутри все практически разрушено, на стенах граффити, разобран паркет и сломан камин. Кстати, объект охраняется, вход в здание запрещен.";

        public static string message75 = "Посмотрите, как выглядел особняк на открытке 1908 года.";

        public static string message76 = "Ранее участок, на котором находится особняк, принадлежал князю Александру Вяземскому, а после смерти князя участок был продан знаменитому ресторатору Эрнесту Игелю, который открывает здесь ресторан “Дача Эрнеста” (1878). Кстати, примерно за 20 лет до приобретения этого участка, Игель открывает ресторан “Медведь” на Большой Конюшенной. В то время он был самым популярным в Санкт-Петербурге: на входе гостей встречал медведь с подносом в лапах.";

        public static string message77 = "Я нашел старые фотографии обоих ресторанов, и оказалось, что внутренние интерьеры очень похожи. Сможете определить, где какой? Выберите интерьер ресторана “Дача Эрнеста”. _За это задание вы можете получить 2 балла._";

        public static string answer77 = "На фотографии №1 можно увидеть стену ресторана с гобеленом, на котором изображены люди в саду. Именно это и напоминало посетителям дачу - казалось, что это просто окно, за котором продолжается природа. И, кстати, оба ресторана располагались в зимних садах. *НИ*";

        public static string message78 = "Известно, что здесь бывали Ф. И. Шаляпин, А. П. Чехов и А. М. Горький.\n" +
            "После революции здесь располагался дом Пролетарской культуры, а потом райсовет, далее - гуманитарный детский центр.Что было дальше? Думаем, вы догадываетесь.Его забросили, но признали объектом культурного наследия.Так медленно погибает особняк, восстанавливать пока что его никто не собирается.";

        public static string message79 = "Представьте, что вы - группа инвесторов. Вы участвуете в конкурсе по восстановлению особняка. Ваша задача - придумать прибыльный проект. Разработайте концепцию и кратко опишите её. Ответ напишите одним сообщением сюда. _За это задание вы можете получить 3 балла._";

        public static string message80 = "*Рядом с этим зданием расположен сквер, носящий имя известного скульптора. Он и станет подсказкой к местоположению десятой, последней станции. Внимательно осмотрите сквер, запомните эту фамилию.*";

        public static string message81 = "Ой! Кажется, пришло время для предпоследней станции. Побежали! *А*";

        public static string message83 = "Участок земли в Вяземском переулке был выделен ЛИТМО после возвращения из эвакуации в 1944. В 1954-1955 здесь было построено новое общежитие. Два пятиэтажных корпуса, соединенные двухэтажной вставкой с воротами, за которыми находился просторный двор со спортплощадкой. Позже, в 1980-1985 во дворе построили еще одно здание общежития, спорткомплекс, столовую и проходную.";

        public static string answer87 = "C 9 января 2013 по 3 ноября 2014 во дворе корпуса университета на Биржевой линии находился памятник Стиву Джобсу в виде гигантского iPhone. Являлся первым памятником Стиву Джобсу в России и третьим памятником в мире. Был выполнен в виде почти двухметрового iPhone 4 — последнего прижизненного iPhone, созданием которого руководил лично Стив Джобс. Являлся интерактивным и оснащённым объёмным (солнечным) QR-кодом.";

        public static string message88 = "А знаете ли вы, что проспект, на котором расположен главный корпус университета, не всегда назывался Кронверкским? Он был переименован в 1991 году, а до этого 60 лет носил имя русского и советского писателя. Попробуйте догадаться, в честь кого был назван проспект и напишите его имя и фамилию.";

        public static string answer88 = "Проспект носил имя русского и советского писателя Максима Горького с 1932 года, такому названию послужило 40-летие его литературной деятельности. В период десоветизации проспекту вернули прежнее название - Кронверкский.";

        public static string message89 = "Самые внимательные ценители архитектуры уже давно заметили голову животного на фасаде одного из корпусов Университета ИТМО. Говорят, что этот барельеф — остатки после огненного жертвоприношения. Как Вы думаете, что это за животное и какой корпус украшает?";

        public static string answer89 = "Есть и другая, не менее удивительная версия появления этого барельефа на здании главного корпуса. Здание Университета ИТМО раньше составляло единое целое с Сытным рынком (вход на рынок был через него), и предполагают, что это символ мясной торговли. Но пока не ясно, что же все-таки хотел сказать этим символом архитектор здания. А у вас есть какие-нибудь догадки?";

        public static string message90 = "Многие корпуса Университета ИТМО являются бывшими доходными домами. В них когда-то жили семьи богатейших купцов и влиятельных баронов. По легенде в одном из корпусов спрятаны сокровища его хозяев. Как вы думаете, где они находятся?";

        public static string answer90 = "По легенде в корпусе университета, расположенном на Биржевой линии Васильевского острова, до сих пор спрятаны сокровища. Как известно, в этом доме жил купец Елисеев. Считается, что между этажами и стенами и находятся сокровища купца Григория Елисеева, который спешно покинул Россию в 1914 году.";

        public static string message901 = "Как и было обещано, последнюю станцию искать вы будете сами. Найдите мастерскую скульптора, про которого я вам уже сегодня рассказывал. 3… 2… 1… Вперед!";

        public static string message93 = "Здесь были созданы сотни произведений разных масштабов и жанров - памятник В. И. Ленину на Московском пр. (1), монумент \"Героическим защитникам Ленинграда\" (2), памятники А. С. Пушкину на площади Искусств (3) и на ст. метро “Пушкинская” (4).";

        public static string message94 = "Пройдите вокруг мастерской и поищите эти памятники (или их части). Какого из них нельзя увидеть за стеклом? Напишите номер фотографии. _За это задание вы можете получить 2 балла._";

        public static string message96 = "Финальная станция - финальное задание. А вы заметили, что после некоторых моих сообщений появлялись странные буквы? Они оказались там не просто так. Составьте слово, которое связано не только со скульптором, но и со всеми зданиями и памятниками культуры, с которыми мы познакомились. _За это задание вы можете получить 3 балла._";

        public static string answer96 = "Архитектоника - от др.-греч. означает “строительное искусство”. Оно означает целостность, завершенность; именно она составляет образ объекта.\n" +
            "Над этим работал не только М.К.Аникушин, но и многие другие архитекторы и скульпторы, о которых мы упоминали сегодня.Они создавали наш город и благодаря им Санкт-Петербург называют Северной Пальмирой и культурной столицей России.";

        public static string message97 = "Электронная слеза бежит по моей щеке, ведь вы дошли до финала, а значит, мне пора с вами прощаться( Мы классно провели это время вместе. Я рад, что вы оказались такими любознательными и креативными компаньонами. " +
            "Я буду всегда вспоминать вашу веселую и энергичную команду. Может оставите свое фото на память?" +
            "\nОтправьте его @nai_bogdan, а то я не умею их хранить. Но он обязательно мне покажет!";

        public static string message98 = "Вы не представляете, как много загадок скрывает наш любимый Санкт-Петербург. Я хочу, чтобы бы вы и дальше старались погружаться в его историю. А если вам будет нужна в этом помощь - не стесняйтесь, " +
            "пишите мне, я приготовлю для вас еще больше увлекательных путешествий, раскрывающих тайны этого великого города.";

        public static string message99 = "*Удачи вам, мои дорогие друзья!*";

        public static string message100 = "С нетерпением ждете результатов? Для того, чтобы они появились как можно быстрее, помогите мне улучшить квест, заполнив форму. А ещё, получите за заполнение +1 балл. Учтите, что заполнить форму должен каждый участник команды!\n" +
            "QR-код для участников команды(капитан, покажи его ребятам или разошли ссылку ниже)\nСсылка: https://forms.gle/m7Vx8QaMWC8GcSC99";
    }


}
