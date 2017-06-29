Evaluation finale du cours .NET � l'IUT Lyon 1
==============================================

Crit�res d'�valuation
---------------------

* Solution apport�e aux probl�mes pos�s dans le fichier Readme.md + r�ponses aux questions (� mettre dans le fichier ci-dessous)
* La qualit� des commits : granularit� fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont �t� modifi�s, c'est inutile, Git le dit d�j�)
* La qualit� du code : utiliser un nommage correct + R# donne des r�gles � respecter, il suffit de les corriger
* Les tests unitaires : expressivit� (le nommage tout particuli�rement), granularit� (i.e on teste une chose � la fois), rapidit� (i.e instantan�), couverture de code et ind�pendance (un test ne d�pend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour �viter de faire du code difficilement maintenable et �volutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et m�thodes donn�s (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez � pousser vos commits sur votre compte GitHub et envoyer votre d�p�t � mon adresse mail.

R�ponses aux questions pos�es
-----------------------------

Q1)Pour �viter d'avoir trop de ifs il faut impl�menter des classes de calculs pour chaque op�rations.

Q2)Le principe central est qu'un objet utilise contient des donn�es et des comportements.

Q3)On r�alise un encapsulation des donn�es, cela permet � une classe d'avoir acc�s seulement aux donn�es qui lui sont utiles.

Q4)Le calculator trainer permet de nous faire remonter des exceptions de calculs que nous avons pas trait�s. Cela nous permet de rajouter des exceptions tels que Format incorect ou division par 0.

Q5)Le principe appliqu� est qu'une classe ne doit changer que pour une seule raison.

Q6)
 
 
 