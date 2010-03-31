Gammu All Mobile Management Utilities
=====================================

Gammu je knihovna a utilita pro příkazovou řádku pro práci s mobilními
telefont. Je vydáno pod GNU GPL verze 2.

Projekt byl původně veden Marcinem Wiackem. Byl založen na zdrojových kódech
projektů Gnokii <http://www.gnokii.org> a pozdějí MyGnokii
<http://www.mwiacek.com>. Gammu bylo (až do verze 0.58) nazýváno MyGnokii2.

V současné době projekt spravuje Michal Čihař <michal@cihar.com> s pomocí
mnoha přispěvovatelů.


Více informací
================

Na stránkách <http://www.gammu.org/> naleznete wiki a systém pro hlášení
chyb, současný správce Gammu udržuje infromace na <http://wammu.eu/gammu/>.


Stáhnutí
==========

Aktuální vydání můžete stáhnout z mnoha zrcadel, hlavní stránky pro stažení
jsou v současné době na <http://dl.cihar.com/gammu/releases/>.

Vývojáře by mohl snajímat aktuální snímek kódu nebo systém správy verzí (v
současné době je používán Git). Informace o nich naleznete na
<http://wammu.eu/gammu/>.

Vývoj probíhá v Gitu, hlavní vývojovou větev naleznete na
<git://gitorious.org/gammu/mainline.git> a prohlížet si jí můžete na
stránkách <http://gitorious.org/gammu/mainline/trees>.


Verze
=====

Existují dva typy vydání - testovací a stabilní, oba mají verzi ve formátu
x.y.z. Stabilní vydání mají obvykle z = 0 nebo nějaké malé číslo a testovací
naopak mají z >= 90. Testovací vydání obvykle poskytují poslední novinky,
ale všechno ještě nemusí být stabilní a plně funkční.


Nastavení
==========

Gammu potřebuje konfigurační soubor aby bylo schopné komunikovat s vaším
telefonem.  Můžete ho vytvořit třeba tím, že vyjdete z příkadů v
docs/config/gammurc, ve kterém jsou popsány všechny parametry, nebo můžete
použít skript utils/gammu-config (nainstalovaný do adresáře bin), který vám
může pomoci vytvořit správné nastavení.

Také můžete zkusit GUI pro Gammu nazývané Wammu (viz <http://wammu.eu/>),
které umí automaticky vytvořit konfiguraci pro váš telefon.

Konfigurační soubor by měl být umístěn v ~/.gammurc nebo /etc/gammurc na
Unixech. Na Windows můžete gammurc umístit do složky Data aplikací ve vašem
profilu nebo ve stejném adresáři z jakého je Gammu spuštěno.

Nějaké rady jak nastavit telefon můžete nalézt v Databázi telefonů Gammu
<http://wammu.eu/phones/>, kam uživatelé zapisují svoje zkušenosti.


Problémy
=========

Pro hlášení chyb používejte <http://bugs.cihar.com/> ne mailing list.  Je
užitečné k hlášení připojit log Gammu se zapnutým laděním. Můžete to provés
přidáním parametrů --debug textall, např.:

   gammu --debug textall --identify


Vývojáři
===========

Nějaké informace jsou dostupné na wiki a v docs/develop/ folder. Můžete si
také vygenerovat dokumentaci pomocí Doxygenu. Dokumentaci API vytvoříte
pomocí make apidoc v adresáři s buildem, můžete si jí prohlédnout na
<http://wammu.eu/docs/devel/api/>. Podobně interní dokumentace může být
vygenerována spuštěním make interndoc a je dostupná na
<http://wammu.eu/docs/devel/itenrnals/>.

Pokud chcete použít libGammu ve vaší aplikaci, vše co musíte udělat je
#include <gammu.h> a pak používat funkce Gammu. V adresáři
docs/develop/examples/ můžete nalézt jednoduché ukázkové aplikace.

Pro ladění může být potřeba zkompilovat Gammu s -DENABLE_PROTECTION=OFF,
jinak jsou ladicí nástroje zmatené z ochran, které GCC do kódu vloží a
backtrace obsahuje nesmyslné informace.


Překlady
=========

Pro překlad programu je používánGettext. Jazyk můžete vybrat pomocí
proměnných prostředí LANG nebo LC_* (na Linuxu se o to obvykle nestaráte, na
Windows stačí exportovat např. LANG=cs_CZ).

Pokud chcete vylepšit stávající překlady, prosím navštivte
<http://l10n.cihar.com/projects/gammu/>. Pro přidání překladu prosím
kontaktujte <michal@cihar.com> a poté již ho budete moci upravovat na
zadaném URL.

Můžete také překládat tradiční cestou vytváření/aktualizací po souborů v
adresáři locale/ a poslání změn do bug trackeru.


Poznámka
=========

Jméno Gammu nemá nic společného s Gammu z knihy "Kacíři Duny" od Franka
Herberta.


Připomínky
============

Jakékoliv připomínky jsou vítány, pokud jste našli chybu, prosím řiďte se
instrukcemi v sekci "Problémy". Vývojáře můžete kontaktovat na mailing listu
<gammu-users@lists.sourceforge.net>.

# vim: et ts=4 sw=4 sts=4 tw=72 spell spelllang=en_us
