namespace Tiamat.WindowsForms
{
    partial class ChartOfAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_pluse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Items.AddRange(new object[] {
            "Национален Сметкоплан",
            "Раздел 1",
            "СМЕТКИ ЗА КАПИТАЛИ",
            "10 Капитал",
            "100 Основен Капитал, изискващ регистрация",
            "101 Основен Капитал, неизискващ регистрация",
            "103 Ликвидационен Капитал при несъстоятелност и ликвидация",
            "104 Капитал на предприятия с нестопанска дейност",
            "11 Резерви",
            "110 Общи резерви",
            "111 Резерви от последваща оценка на дълготрайни активи",
            "112 Резерви от последваща оценка на краткотрайни активи",
            "113 Резерви от последащва оценка на финансови инструменти",
            "114 Резерви на инвестиоционни дружества",
            "115 Резерви на пенсионни дружества",
            "119 Други резерви",
            "12 Финансови резултати",
            "120 Непокрита загуба от минали години",
            "121 Неразпределена печалба от минали години",
            "122 Печалби и загуби от текущата година",
            "123 Резултат от дейността на предприятия с нестопанска дейност",
            "124 Резултат при несъстоятелност и ликвидация",
            "13 Резерви по застраховатенли договори",
            "130 Резерви за животозастраховане",
            "131 Пренос-премийни резерви",
            "132 Резерви за предстоящи плащания",
            "133 Резерви за запасен фонд",
            "134 Резерви за презастраховане",
            "139 Други резерви по застрахователни договори",
            "14 Емисии",
            "141 Банкноти за обращение",
            "142 Монети за обращение",
            "15 Получени заеми",
            "150 Получени краткосрочни заеми",
            "151 Получени дългосрочни заеми",
            "152 Дългови инструменти",
            "159 Други заеми и дългове",
            "16 Приети и срочни депозити",
            "160 Приети срочни депозити от банки и други",
            "161 Приети срочни депозити от нефинансови предприятия и други клиенти",
            "17 Привличени средства по разплащателни сметки",
            "170 Разплащателни сметки на банки и други финансови институции",
            "171 Рапзращателни сметки на нефинансови предприятия и други клиенти",
            "172 Привлечени средства по специални сметки",
            "173 Привлечени средства влогови сметки",
            "179 Други сметки на клиенти",
            "18 Привлечени средста от участници в осигурителни фондове",
            "180 Сметки на участници в пенсионното осигуряване",
            "181 Сметки на участници в здравното осигуряване",
            "189 Сметки на участници в други осигурителни фондове",
            "19 Премии и сконто по финансови инструменти",
            "190 Премии, свързани с капитал",
            "191 Отбиви (сконто), свързани с капитал",
            "192 Премии, произтичащи от финансови инструменти",
            "193 Сконто от финансови интрументи",
            "Раздел 2",
            "СМЕТКИ ЗА ДЪЛГОТРАЙНИ АКТИВИ",
            "20 Дълготрайни материални активи ",
            "200 Земи (терени)",
            "201 Подобрения върху земите",
            "202 Сгради и конструкции",
            "203 Машини и оборудване",
            "204 Съоръжения",
            "205 Транспортни средства",
            "206 Компютърно оборудване",
            "207 Обзавеждане и трайни активи",
            "208 Библиотечни книги",
            "209 Други дълготрайни материални активи",
            "21 Дълготрайни нематериални активи ",
            "212 Продукти от развойна дейност ",
            "213 Права върху интелектуалната собственост ",
            "214 Програмни продукти ",
            "215 Права върху индустриална собственост ",
            "219 Други дълготрайни нематериални активи",
            "22 Дълготрайни финансови активи",
            "220 Инвестиции в дъщерни предприятия",
            "221 Инвестиции в асоциирани предприятия",
            "222 Инвестиции в смесени предприятия",
            "223 Инвестиционни имоти",
            "224 Финансови активи, държани до настъпването на падежа",
            "225 Финансови активи, обявени за продажба",
            "226 Финансови активи, заложени като обезпечение",
            "229 Други дългосрочни финансови активи",
            "23 Търговска репутация",
            "230 Положителна търговска репутация",
            "231 Отрицателна търговска репутация",
            "24 Амортизация",
            "240 Амортизация на ДМА",
            "241 Амортизация на дълготрайни нематериални активи",
            "25 Провизии за покриване на рискови активи и задължения",
            "250 Провизии за покриване на рискови активи",
            "251 Провизии, признати като пасиви",
            "259 Други провизии",
            "26 Дългосрочни вземания и заеми",
            "260 Дългосрочни вземания и заеми на банки и други финансови инситуции",
            "261 Дългосрочни вземания и заеми на банки и други нефинансови институции ",
            "262 Просрочени дългосрочни вземания и заеми",
            "263 Дългосрочни вземания и заеми, заложени като обеспечения",
            "269 Други дългосрочни вземания и заеми",
            "",
            "27 Дълготраийни биологични активи",
            "270 Гори",
            "271 Трайни насаждения - плододоващи",
            "272 Трайни насаждения - неплододаващи",
            "273 Животни в основни стада",
            "Раздел 3",
            "СМЕТКИ ЗА СТОКОВО-МАТЕРИАЛНИ ЗАПАСИ",
            "30 Материали, продукция и стоки",
            "300 Доставки",
            "301 Материали",
            "302 Продукция",
            "303 Стоки",
            "304 Изпратени стоки и предадени работи",
            "31 Краткотрайни биологични активи ",
            "310 Дребни продуктивни животни",
            "311 Птици - основни стада",
            "312 Пчелни семейства",
            "313 Млади животни",
            "314 Животни за угояване",
            "315 Животни за експериментални цели",
            "Раздел 4",
            "СМЕТКИ ЗА РАЗЧЕТИ",
            "40 Доставчици и свързани с тях сметки",
            "400 Доставчици",
            "401 Доставчици по аванси",
            "402 Доставчици по търговски кредити",
            "403 Доставчици по доставки при определени условия",
            "404 Доставчици по доставки със свързани лица",
            "409 Други разчети с доставчици",
            "41 Клиенти и свързани с тях сметки",
            "410 Клиенти",
            "411 Клиенти по аванси",
            "412 Клиенти по търговски кредити",
            "413 Клиенти по продажби при определени условия",
            "414 Клиенти по продажби със свързани лица",
            "419 Други разчети и клиенти",
            "42 Персонал и съдружници",
            "420 Персонал",
            "421 Задължения по неизползвани отпуски",
            "422 Подотчетни лица",
            "423 Вземания от съучастия",
            "424 Задължения за съучастия",
            "425 Вземания по записи дялови вноски",
            "429 Други разчети с персонала и съдружниците",
            "43 Разчети по преводи и вътрешни разчети",
            "430 Разчети по междубанкови операции",
            "431 Вътрешни разчети по междубанкови операции",
            "432 Вътрешни разчети по вътрешнобанкови операции",
            "433 Вътрешни разчети",
            "44 Вземания по липси, начети и съдебни спорове",
            "440 Вземания по рекламации",
            "441 Вземания по липси и начети",
            "442 Ценови разлики по липси и начети",
            "443 Вземания по съдебни спорове",
            "444 Присъдени вземания",
            "",
            "45 Разчети с бюджета с ведемоства ",
            "450 Разчети с общините",
            "451 Разчети за данъци върху печалбата",
            "452 Разчети за данъци върху доходи на физически лица",
            "453 Разчети за данък върху добавената стойност",
            "454 Разчети с министерства",
            "455 Разчети за акцизи ",
            "456 Разчети с митници",
            "459 Други разчети с бюджета и в ведомства",
            "46 Разчети с бюджета и с ведомства",
            "460 Разчети с фонд пенсии",
            "461 Разчети с фонд Трудова злополука",
            "462 Разчети с фонд Общо заболяване и майчинство",
            "463 Разчети за допълнително задължително социално осигуряване",
            "464 Разчети за доброволно социално осигуряване",
            "465 Разчети за здравно осигуряване",
            "466 Разчети с фонд Безработица",
            "467 Разчети за еднократни помощи и детски надбавки",
            "469 Други Разчети с осигурителни",
            "47 Разчети с международни финансови институции",
            "470 Разчети с Международния валутен фонд",
            "471 Разчети със Световната банка",
            "472 Разчети с други международни финансови инситуции",
            "473 Разчети по междуправителствени спогодби",
            "48 Разчети по застраховане и съзастраховане",
            "480 Разчети по предстоящи плащания",
            "481 Разчети по състраховане",
            "482 Разчети с презастраховане",
            "483 Разчети със седанти",
            "489 Други разчети",
            "49 Разни дебитори и кредитори",
            "490 Доверители",
            "491 Разчети за гаранции",
            "492 Разчети със собственици",
            "493 Разчети по застраховане",
            "494 Разчети по лихва",
            "495 Разчети по отстрочени данъци",
            "498 Други дебитори",
            "499 Други кредитори",
            "Раздел 5",
            "СМЕТКИ ЗА ФИНАНСОВИ СРЕДСТВА",
            "50 Парични средства",
            "500 Каса в левове",
            "501 Кава във валута",
            "502 Разплащателна сметка в левове",
            "503 Разплащателна сметка във валута",
            "504 Акредитиви в левове",
            "505 Акредитиви във валута",
            "506 Предоставени депозити",
            "507 Разплащателни чекове",
            "508 Парични средства, заложени като обезпечение",
            "509 Други парични средства",
            "51 Краткосрочни финансови активи",
            "510 Финансови активи, държани за търговия",
            "511 Изкупени собствени облигации",
            "512 Държавни цении книжа",
            "513 Благородни метали и скъпоценни камъни",
            "514 Финансови активи, заложени като обезпечение",
            "519 Други краткосрочни финансови активи",
            "53 Краткосрочни вземания и заеми",
            "530 Краткосрочни вземания и заеми от банки и други финансови институции",
            "531 Краткосрочни вземания и заеми от нефинансови предприятия и други клиенти",
            "532 Краткосрочни вземания и заеми, заложени като обезпечение",
            "533 Просрочени краткосрочни вземания и заеми",
            "539 Други краткосрочни вземания и заеми",
            "Раздел 6",
            "СМЕТКИ И РАЗХОДИ",
            "60 Разходи по икономически елементи",
            "600 Разходи за материали",
            "601 Разходи за външни услуги",
            "602 Разходи за амортизация",
            "603 Разходи за заплати (възнаграждения)",
            "604 Разходи за осигуровки",
            "605 Разходи за данъци, такси и други подобни плащания",
            "606 Разходи за провизии",
            "607 Разходи за участие",
            "609 Други разходи",
            "61 Разходи по дейността ",
            "610 Разходи за основна дейност",
            "611 Разходи за спомагателна дейност",
            "612 Разходи за продажба на продукция",
            "613 Разходи за придобиване на ДМА",
            "614 Разходи за ликвадаация на ДМА",
            "615 Разходи при ликвидация и несъстоятелност",
            "616 Разходи по дейности в предприятия с нестопанска дейност",
            "617 Административни разходи",
            "62 Финансови разходи",
            "620 Разходи за лихви",
            "621 Разходи за провизиране на рискови активи ",
            "622 Разходи по операции с финансови активи и инсрументи",
            "623 Разходи от последващи оценки на финансови активи и инструменти",
            "624 Разходи по валутни операции",
            "629 Други финансови разходи",
            "65 Разходи за бъдещи периоди",
            "650 Разходи за бъдещи периоди",
            "651 Разходи за учредяване и разширяване",
            "652 Финансови разходи за бъдещи периоди",
            "",
            "66 Разходи по пряко застраховане",
            "660 Разходи за суми по застраховането",
            "661 Разходи за участие в резултата",
            "662 Разходи за ликвидация",
            "663 Разходи за комисионни по застраховането ",
            "664 Разходи за резерви по застраховането",
            "669 Други разходи по пряко застраховане",
            "67 Разходи по пасивно презастраховане",
            "670 Разходи за отсъпени премии на презастрахователи",
            "671 Разходи за освободени резерви по пасивното презастраховане",
            "679 Други разходи по пасивното презастраховане",
            "68 Разходи по активно презастраховане",
            "680 Разходи за застрахователни обезщетения",
            "681 Разходи за участие в резултата",
            "682 Разходи за участие в ликвидацията",
            "683 Разходи за отстъпени презастрахователни комисионни и такси",
            "684 Разходи за далечни резерви по активно презастраховане ",
            "689 Други разходи по активно презастраховане",
            "",
            "69 Извънредни разходи",
            "690 Извънредни разходи",
            "Раздел 7",
            "СМЕТКИ ЗА ПРИХОДИ",
            "70 Приходи от продажби",
            "700 Приходи от продажби на продукция",
            "701 Приходи от продажби на стоки",
            "702 Приходи от продажби на услуги",
            "703 Приходи от продажби на консигнация",
            "704 Приходи от продажби на дълготрайни активи",
            "705 Приходи от продажби на материали",
            "706 Приходи от финансирания",
            "707 Приходи от ликвидация и несъстоятелност",
            "709 Други приходи от дейността",
            "71 Приходи в предприятия с нестопанска дейност",
            "710 Приходи от регламентирана дейност",
            "711 Приходи от членски внос",
            "712 Приходи от дарения",
            "713 Приходи от субсидии",
            "719 Други приходи",
            "72 Финансови приходи",
            "720 Приходи от лихви",
            "721 Приходи от съучастия",
            "722 Приходи от операции с финансови активи и инструменти",
            "723 Приходи от последващи оценки на финансови активи и инструменти",
            "724 Приходи от валутни операции",
            "725 Приходи от реинтегрирани провизии",
            "729 Други финансови приходи",
            "",
            "75 Приходи за бъдещи периоди и финансирания",
            "750 Приходи за бъдещи периоди",
            "751 Финансиране за дълготрайни активи",
            "752 Финансиране за текуща дейност",
            "753 Финансови приходи за бъдещи периоди",
            "76 Приходи от пряко застраховане",
            "760 Приходи от премии по застраховането",
            "761 Приходи от комисионни и таксии",
            "762 Приходи по застраховане от минали години",
            "763 Приходи от регресии",
            "764 Приходи от особени резерви",
            "769 Други застрахователни приходи",
            "77 Приходи от пасивно застраховане",
            "770 Приходи от получени обезщетения от презастрахователите",
            "771 Приходи от участие в резултата на презастрахователите",
            "772 Приходи от комисионни от презастрахователите",
            "773 Приходи от пасивно презастраховане от минали години",
            "774 Приходи от приходи за презастраховане",
            "779 Други приходи от пасивно презастраховане",
            "78 Приходи от активно застраховане",
            "780 Приходи от премии по презастраховане",
            "781 Приходи от активно презастраховане от минали години",
            "782 Приходи от регресии по активно презастраховане",
            "783 Приходи от резерви по активно презастраховане",
            "789 Други приходи от активно презастраховане",
            "79 Извънредни приходи",
            "790 Извъренди приходи",
            "Раздел 9",
            "СМЕТКИ ЗА УСЛОВНИ АКТИВИ И УСЛОВНИ ПАСИВИ",
            "91 Чужди материални и нематериални активи",
            "910 Чужди материални и нематериални активи, предоставени като обезпечение",
            "911 Наети чужди активи",
            "912 Чужди материални активи получени по консигнационен догоор",
            "913 Документи под особена отчетност",
            "914 Нефинансови ценности, приети за съхраняване",
            "92 Чужди финансови активи",
            "920 Чужди финансови активи, предпоставени като обезпечение",
            "921 Заложени полици",
            "922 Разни емисии за пускане в обръщение",
            "923 Чужди финансови активи, държани от името на клиенти",
            "924 Поети задължения по договора",
            "93 Дебитори по условния вземания",
            "930 Вземания по предоставени кредити по междудържавни спогодби",
            "931 Отписани непогасени вземания",
            "932 Дебитори по операции на инкасиране",
            "933 Вземания по дериватни сметки",
            "94 Условни активи",
            "940 Вземания по спотоперации",
            "941 Отписани непогасени вземания",
            "942 Дебитори по операции за инкасиране",
            "943 Условни вземания по други банкови операции",
            "95 Кредитори по условни задължения",
            "950 Гаранции и други подобни непредвидени задължения",
            "951 Неотменяаеми ангажименти",
            "952 Отменяаеми ангажименти",
            "953 Задължения по спотоперации",
            "954 Задължения по дериватни сделки",
            "955 Условни задължения по други банкови операции",
            "96 Собствени активи, невключени в стопанския оборот",
            "960 Резервна каса",
            "961 Активи в употреба, отчетени в разход",
            "97 Собствени пасиви, невключени в стопанския оборот",
            "970 Емисионен резерв",
            "971 Собствени емисии извън обръщение с изтекъл срок за обмяна",
            "98 Разни сметки за условни активи",
            "980 Сметки по резервите",
            "981 Сметки по изкупени обезпечения",
            "982 Ангажименти по разрешени кредити",
            "983 Разни статистически сметки",
            "989 Други сметки за условни активи",
            "99 Разни сметки за условни пасиви",
            "999 Други сметки за условни пасив",
            ""});
            this.listBox.Location = new System.Drawing.Point(3, 61);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(692, 421);
            this.listBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(692, 52);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_search);
            this.flowLayoutPanel1.Controls.Add(this.textBox_search);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(3, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(65, 17);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "Търсене";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(3, 20);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(150, 20);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_minus);
            this.flowLayoutPanel2.Controls.Add(this.button_pluse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(349, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(340, 46);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(307, 3);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(30, 20);
            this.button_minus.TabIndex = 2;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_pluse
            // 
            this.button_pluse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pluse.Location = new System.Drawing.Point(271, 3);
            this.button_pluse.Name = "button_pluse";
            this.button_pluse.Size = new System.Drawing.Size(30, 20);
            this.button_pluse.TabIndex = 3;
            this.button_pluse.Text = "+";
            this.button_pluse.UseVisualStyleBackColor = true;
            this.button_pluse.Click += new System.EventHandler(this.button_pluse_Click);
            // 
            // ChartOfAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChartOfAccounts";
            this.Text = "ChartOfAccounts";
            this.Load += new System.EventHandler(this.ChartOfAccounts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_pluse;
        private System.Windows.Forms.Label label_search;

    }
}