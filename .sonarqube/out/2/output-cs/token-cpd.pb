ì6
wC:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Controllers\AppointmentController.cs
	namespace 	
deusbarbershop
 
. 
Controllers $
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class !
AppointmentController &
:' (
ControllerBase) 7
{ 
private 
readonly  
ApplicationDbContext -
_context. 6
;6 7
public !
AppointmentController $
($ % 
ApplicationDbContext% 9
context: A
)A B
{ 	
_context 
= 
context 
; 
} 	
[%% 	
HttpGet%%	 
]%% 
public&& 
async&& 
Task&& 
<&& 
ActionResult&& &
<&&& '
IEnumerable&&' 2
<&&2 3
Appointment&&3 >
>&&> ?
>&&? @
>&&@ A
GetAppointments&&B Q
(&&Q R
)&&R S
{'' 	
return(( 
await(( 
_context(( !
.((! "
Appointments((" .
.((. /
Include)) 
()) 
customer))  
=>))! #
customer))$ ,
.)), -
Customer))- 5
)))5 6
.))6 7
Include** 
(** 
service** 
=>**  "
service**# *
.*** +
Service**+ 2
)**2 3
.**3 4
ToListAsync++ 
(++ 
)++ 
;++ 
},, 	
[44 	
HttpGet44	 
(44 
$str44 
)44 
]44 
public55 
async55 
Task55 
<55 
ActionResult55 &
<55& '
Appointment55' 2
>552 3
>553 4
GetAppointment555 C
(55C D
int55D G
id55H J
)55J K
{66 	
var77 
appointment77 
=77 
await77 #
_context77$ ,
.77, -
Appointments77- 9
.779 :
	FindAsync77: C
(77C D
id77D F
)77F G
;77G H
if99 
(99 
appointment99 
==99 
null99 #
)99# $
{:: 
return;; 
NotFound;; 
(;;  
);;  !
;;;! "
}<< 
return>> 
appointment>> 
;>> 
}?? 	
[GG 	
HttpPostGG	 
(GG 
$strGG %
)GG% &
]GG& '
publicHH 
asyncHH 
TaskHH 
<HH 
IActionResultHH '
>HH' (
PutAppointmentHH) 7
(HH7 8%
RequestAppointmentDetailsHH8 Q
appointmentHHR ]
)HH] ^
{II 	
varKK 
resultKK 
=KK 
awaitKK 
_contextKK '
.KK' (
AppointmentsKK( 4
.KK4 5
	FindAsyncKK5 >
(KK> ?
appointmentKK? J
.KKJ K
IDKKK M
)KKM N
;KKN O
ifMM 
(MM 
resultMM 
!=MM 
nullMM 
)MM 
{NN 
resultOO 
.OO 
AppointmentDateOO &
=OO' (
appointmentOO) 4
.OO4 5
DateOO5 9
;OO9 :
awaitPP 
_contextPP 
.PP 
SaveChangesAsyncPP /
(PP/ 0
)PP0 1
;PP1 2
returnRR 
OkRR 
(RR 
$strRR =
)RR= >
;RR> ?
}SS 
returnUU 

BadRequestUU 
(UU 
$strUU A
)UUA B
;UUB C
}WW 	
[^^ 	
HttpPost^^	 
]^^ 
public__ 
async__ 
Task__ 
<__ 
ActionResult__ &
<__& '
Appointment__' 2
>__2 3
>__3 4
PostAppointment__5 D
(__D E%
RequestAppointmentDetails__E ^
requestAppointment___ q
)__q r
{`` 	
DateTimeaa 
nowaa 
=aa 
DateTimeaa #
.aa# $
Nowaa$ '
;aa' (
ifbb 
(bb 
nowbb 
>=bb 
requestAppointmentbb )
.bb) *
Datebb* .
)bb. /
{cc 
throwcc 
newcc 
ArgumentExceptioncc )
(cc) *
$str	cc* Å
)
ccÅ Ç
;
ccÇ É
}
ccÑ Ö
elsedd 
{ee 
Appointmentff 
appointmentff '
=ff( )
newff* -
(ff- .
)ff. /
{gg 
AppointmentDatehh #
=hh$ %
requestAppointmenthh& 8
.hh8 9
Datehh9 =
,hh= >
Customerii 
=ii 
requestAppointmentii 1
.ii1 2
Customerii2 :
,ii: ;

Service_Idjj 
=jj  
requestAppointmentjj! 3
.jj3 4

Service_Idjj4 >
}kk 
;kk 
_contextmm 
.mm 
Appointmentsmm %
.mm% &
Addmm& )
(mm) *
appointmentmm* 5
)mm5 6
;mm6 7
awaitnn 
_contextnn 
.nn 
SaveChangesAsyncnn /
(nn/ 0
)nn0 1
;nn1 2
returnoo 
Okoo 
(oo 
)oo 
;oo 
}pp 
}rr 	
[zz 	

HttpDeletezz	 
(zz 
$strzz 
)zz 
]zz 
public{{ 
async{{ 
Task{{ 
<{{ 
IActionResult{{ '
>{{' (
DeleteAppointment{{) :
({{: ;
int{{; >
id{{? A
){{A B
{|| 	
var}} 
appointment}} 
=}} 
await}} #
_context}}$ ,
.}}, -
Appointments}}- 9
.}}9 :
	FindAsync}}: C
(}}C D
id}}D F
)}}F G
;}}G H
if~~ 
(~~ 
appointment~~ 
==~~ 
null~~ #
)~~# $
{ 
return
ÄÄ 
NotFound
ÄÄ 
(
ÄÄ  
)
ÄÄ  !
;
ÄÄ! "
}
ÅÅ 
_context
ÉÉ 
.
ÉÉ 
Appointments
ÉÉ !
.
ÉÉ! "
Remove
ÉÉ" (
(
ÉÉ( )
appointment
ÉÉ) 4
)
ÉÉ4 5
;
ÉÉ5 6
await
ÑÑ 
_context
ÑÑ 
.
ÑÑ 
SaveChangesAsync
ÑÑ +
(
ÑÑ+ ,
)
ÑÑ, -
;
ÑÑ- .
return
ÜÜ 
	NoContent
ÜÜ 
(
ÜÜ 
)
ÜÜ 
;
ÜÜ 
}
áá 	
}
àà 
}ââ çG
tC:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Controllers\CustomerController.cs
	namespace 	
deusbarbershop
 
. 
Controllers $
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
CustomerController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
ICustomerRepository ,
_customerRepository- @
;@ A
private 
readonly 
IMapper  
_mapper! (
;( )
public 
CustomerController !
(! "
ICustomerRepository" 5
customerRepository6 H
,H I
IMapperJ Q
mapperR X
)X Y
{ 	
_customerRepository   
=    !
customerRepository  " 4
;  4 5
_mapper!! 
=!! 
mapper!! 
;!! 
}"" 	
[(( 	
HttpGet((	 
](( 
[)) 	 
ProducesResponseType))	 
()) 
StatusCodes)) )
.))) *
Status200OK))* 5
)))5 6
]))6 7
[** 	 
ProducesResponseType**	 
(** 
StatusCodes** )
.**) *(
Status500InternalServerError*** F
)**F G
]**G H
public++ 
async++ 
Task++ 
<++ 
IActionResult++ '
>++' (
GetCustomers++) 5
(++5 6
)++6 7
{,, 	
try-- 
{.. 
var// 
	customers// 
=// 
await//  %
_customerRepository//& 9
.//9 :
GetAll//: @
(//@ A
)//A B
;//B C
return00 
Ok00 
(00 
	customers00 #
)00# $
;00$ %
}11 
catch22 
(22 
	Exception22 
)22 
{33 
return44 

StatusCode44 !
(44! "
$num44" %
,44% &
$str44' _
)44_ `
;44` a
}55 
}77 	
[== 	
HttpGet==	 
(== 
$str== 
)== 
]== 
[>> 	 
ProducesResponseType>>	 
(>> 
StatusCodes>> )
.>>) *
Status200OK>>* 5
)>>5 6
]>>6 7
[?? 	 
ProducesResponseType??	 
(?? 
StatusCodes?? )
.??) *(
Status500InternalServerError??* F
)??F G
]??G H
[@@ 	 
ProducesResponseType@@	 
(@@ 
StatusCodes@@ )
.@@) *
Status404NotFound@@* ;
)@@; <
]@@< =
publicAA 
asyncAA 
TaskAA 
<AA 
IActionResultAA '
>AA' (
GetCustomerByIdAA) 8
(AA8 9
intAA9 <
idAA= ?
)AA? @
{BB 	
tryCC 
{DD 
varEE 
customerEE 
=EE 
awaitEE $
_customerRepositoryEE% 8
.EE8 9
GetByIdEE9 @
(EE@ A
idEEA C
)EEC D
;EED E
ifFF 
(FF 
customerFF 
==FF 
nullFF  $
)FF$ %
{GG 
returnHH 
NotFoundHH #
(HH# $
)HH$ %
;HH% &
}II 
returnJJ 
OkJJ 
(JJ 
customerJJ "
)JJ" #
;JJ# $
}KK 
catchLL 
(LL 
	ExceptionLL 
)LL 
{MM 
returnNN 

StatusCodeNN !
(NN! "
$numNN" %
,NN% &
$strNN' _
)NN_ `
;NN` a
}OO 
}QQ 	
[WW 	
HttpPostWW	 
]WW 
[XX 	 
ProducesResponseTypeXX	 
(XX 
StatusCodesXX )
.XX) *
Status200OKXX* 5
)XX5 6
]XX6 7
[YY 	 
ProducesResponseTypeYY	 
(YY 
StatusCodesYY )
.YY) *
Status400BadRequestYY* =
)YY= >
]YY> ?
[ZZ 	 
ProducesResponseTypeZZ	 
(ZZ 
StatusCodesZZ )
.ZZ) *(
Status500InternalServerErrorZZ* F
)ZZF G
]ZZG H
public[[ 
async[[ 
Task[[ 
<[[ 
IActionResult[[ '
>[[' (
CreateUpdate[[) 5
([[5 6
[[[6 7
FromBody[[7 ?
][[? @
CustomerDto[[A L
customerDTO[[M X
)[[X Y
{\\ 	
try]] 
{^^ 
if__ 
(__ 
customerDTO__ 
==__  "
null__# '
)__' (
{`` 
returnaa 

BadRequestaa %
(aa% &

ModelStateaa& 0
)aa0 1
;aa1 2
}bb 
ifcc 
(cc 
!cc 

ModelStatecc 
.cc  
IsValidcc  '
)cc' (
{dd 
returnee 

BadRequestee %
(ee% &

ModelStateee& 0
)ee0 1
;ee1 2
}ff 
varhh 
customerhh 
=hh 
_mapperhh &
.hh& '
Maphh' *
<hh* +
Customerhh+ 3
>hh3 4
(hh4 5
customerDTOhh5 @
)hh@ A
;hhA B
varii 
responseii 
=ii 
awaitii $
_customerRepositoryii% 8
.ii8 9
CreateUpdateii9 E
(iiE F
customeriiF N
)iiN O
;iiO P
ifjj 
(jj 
responsejj 
==jj 
nulljj  $
)jj$ %
{kk 
returnll 

StatusCodell %
(ll% &
$numll& )
,ll) *
$strll+ Z
)llZ [
;ll[ \
}mm 
returnnn 
Oknn 
(nn 
responsenn "
)nn" #
;nn# $
}oo 
catchpp 
(pp 
	Exceptionpp 
)pp 
{qq 
returnrr 

StatusCoderr !
(rr! "
$numrr" %
,rr% &
$strrr' V
)rrV W
;rrW X
}ss 
}tt 	
[zz 	

HttpDeletezz	 
(zz 
$strzz 
)zz 
]zz 
[{{ 	 
ProducesResponseType{{	 
({{ 
StatusCodes{{ )
.{{) *
Status400BadRequest{{* =
){{= >
]{{> ?
[|| 	 
ProducesResponseType||	 
(|| 
StatusCodes|| )
.||) *
Status404NotFound||* ;
)||; <
]||< =
[}} 	 
ProducesResponseType}}	 
(}} 
StatusCodes}} )
.}}) *
Status204NoContent}}* <
)}}< =
]}}= >
[~~ 	 
ProducesResponseType~~	 
(~~ 
StatusCodes~~ )
.~~) *(
Status500InternalServerError~~* F
)~~F G
]~~G H
public 
async 
Task 
< 
IActionResult '
>' (
Delete) /
(/ 0
int0 3
id4 6
)6 7
{
ÄÄ 	
try
ÅÅ 
{
ÇÇ 
if
ÉÉ 
(
ÉÉ 
id
ÉÉ 
<
ÉÉ 
$num
ÉÉ 
)
ÉÉ 
{
ÑÑ 
return
ÖÖ 

BadRequest
ÖÖ %
(
ÖÖ% &
)
ÖÖ& '
;
ÖÖ' (
}
ÜÜ 
var
áá 
customer
áá 
=
áá 
await
áá $!
_customerRepository
áá% 8
.
áá8 9
GetById
áá9 @
(
áá@ A
id
ááA C
)
ááC D
;
ááD E
if
àà 
(
àà 
customer
àà 
==
àà 
null
àà  $
)
àà$ %
{
ââ 
return
ää 
NotFound
ää #
(
ää# $
)
ää$ %
;
ää% &
}
ãã 
var
åå 
	isSuccess
åå 
=
åå 
await
åå  %!
_customerRepository
åå& 9
.
åå9 :
Delete
åå: @
(
åå@ A
customer
ååA I
)
ååI J
;
ååJ K
if
çç 
(
çç 
!
çç 
	isSuccess
çç 
)
çç 
{
éé 
return
èè 

StatusCode
èè %
(
èè% &
$num
èè& )
,
èè) *
$str
èè+ Z
)
èèZ [
;
èè[ \
}
êê 
return
ëë 
	NoContent
ëë  
(
ëë  !
)
ëë! "
;
ëë" #
}
íí 
catch
ìì 
(
ìì 
	Exception
ìì 
)
ìì 
{
îî 
return
ïï 

StatusCode
ïï !
(
ïï! "
$num
ïï" %
,
ïï% &
$str
ïï' V
)
ïïV W
;
ïïW X
}
ññ 
}
òò 	
}
ôô 
}öö ˝
qC:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Controllers\OwnerController.cs
	namespace 	
deusbarbershop
 
. 
Controllers $
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
OwnerController  
:! "

Controller# -
{ 
private 
readonly 
SignInManager &
<& '
ApplicationOwner' 7
>7 8
_signInManager9 G
;G H
private 
readonly 
UserManager $
<$ %
ApplicationOwner% 5
>5 6
_userManager7 C
;C D
public 
OwnerController 
( 
SignInManager ,
<, -
ApplicationOwner- =
>= >
signInManager? L
,L M
UserManager 
< 
ApplicationOwner (
>( )
userManager* 5
)5 6
{   	
_signInManager!! 
=!! 
signInManager!! *
;!!* +
_userManager"" 
="" 
userManager"" &
;""& '
}## 	
[)) 	
AllowAnonymous))	 
])) 
[** 	
HttpPost**	 
]** 
public++ 
async++ 
Task++ 
<++ 
IActionResult++ '
>++' (
Login++) .
(++. /
[++/ 0
FromBody++0 8
]++8 9
LoginDto++: B
loginDTO++C K
)++K L
{,, 	
try-- 
{.. 
var// 
username// 
=// 
loginDTO// '
.//' (
EmailAddress//( 4
;//4 5
var00 
password00 
=00 
loginDTO00 '
.00' (
Password00( 0
;000 1
var22 
result22 
=22 
await22 "
_signInManager22# 1
.221 2
PasswordSignInAsync222 E
(22E F
username22F N
,22N O
password22P X
,22X Y
false22Z _
,22_ `
false22a f
)22f g
;22g h
if33 
(33 
result33 
.33 
	Succeeded33 $
)33$ %
{44 
var55 
user55 
=55 
await55 $
_userManager55% 1
.551 2
FindByEmailAsync552 B
(55B C
username55C K
)55K L
;55L M
return77 
Ok77 
(77 
user77 "
)77" #
;77# $
}88 
return99 
Unauthorized99 #
(99# $
loginDTO99$ ,
)99, -
;99- .
}:: 
catch;; 
(;; 
	Exception;; 
);; 
{<< 
return== 

StatusCode== !
(==! "
$num==" %
,==% &
$str==' _
)==_ `
;==` a
}>> 
}?? 	
}@@ 
}AA §G
sC:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Controllers\ServiceController.cs
	namespace

 	
deusbarbershop


 
.

 
Controllers

 $
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
ServiceController "
:# $
ControllerBase% 3
{ 
private 
readonly 
IServiceRepository +
_serviceRepository, >
;> ?
private 
readonly 
IMapper  
_mapper! (
;( )
public 
ServiceController  
(  !
IServiceRepository! 3
serviceRepository4 E
,E F
IMapperG N
mapperO U
)U V
{ 	
_serviceRepository   
=    
serviceRepository  ! 2
;  2 3
_mapper!! 
=!! 
mapper!! 
;!! 
}"" 	
[(( 	
HttpGet((	 
](( 
[)) 	 
ProducesResponseType))	 
()) 
StatusCodes)) )
.))) *
Status200OK))* 5
)))5 6
]))6 7
[** 	 
ProducesResponseType**	 
(** 
StatusCodes** )
.**) *(
Status500InternalServerError*** F
)**F G
]**G H
public++ 
async++ 
Task++ 
<++ 
IActionResult++ '
>++' (
GetServices++) 4
(++4 5
)++5 6
{,, 	
try-- 
{.. 
var// 
services// 
=// 
await// $
_serviceRepository//% 7
.//7 8
GetAll//8 >
(//> ?
)//? @
;//@ A
return00 
Ok00 
(00 
services00 "
)00" #
;00# $
}11 
catch22 
(22 
	Exception22 
)22 
{33 
return44 

StatusCode44 !
(44! "
$num44" %
,44% &
$str44' _
)44_ `
;44` a
}55 
}66 	
[== 	
HttpGet==	 
(== 
$str== 
)== 
]== 
[>> 	 
ProducesResponseType>>	 
(>> 
StatusCodes>> )
.>>) *
Status200OK>>* 5
)>>5 6
]>>6 7
[?? 	 
ProducesResponseType??	 
(?? 
StatusCodes?? )
.??) *(
Status500InternalServerError??* F
)??F G
]??G H
[@@ 	 
ProducesResponseType@@	 
(@@ 
StatusCodes@@ )
.@@) *
Status404NotFound@@* ;
)@@; <
]@@< =
publicAA 
asyncAA 
TaskAA 
<AA 
IActionResultAA '
>AA' (
GetServiceByIdAA) 7
(AA7 8
intAA8 ;
idAA< >
)AA> ?
{BB 	
tryCC 
{DD 
varEE 
serviceEE 
=EE 
awaitEE #
_serviceRepositoryEE$ 6
.EE6 7
GetByIdEE7 >
(EE> ?
idEE? A
)EEA B
;EEB C
ifFF 
(FF 
serviceFF 
==FF 
nullFF #
)FF# $
{GG 
returnHH 
NotFoundHH #
(HH# $
)HH$ %
;HH% &
}II 
returnJJ 
OkJJ 
(JJ 
serviceJJ !
)JJ! "
;JJ" #
}KK 
catchLL 
(LL 
	ExceptionLL 
)LL 
{MM 
returnNN 

StatusCodeNN !
(NN! "
$numNN" %
,NN% &
$strNN' _
)NN_ `
;NN` a
}OO 
}QQ 	
[WW 	
HttpPostWW	 
]WW 
[XX 	 
ProducesResponseTypeXX	 
(XX 
StatusCodesXX )
.XX) *
Status200OKXX* 5
)XX5 6
]XX6 7
[YY 	 
ProducesResponseTypeYY	 
(YY 
StatusCodesYY )
.YY) *
Status400BadRequestYY* =
)YY= >
]YY> ?
[ZZ 	 
ProducesResponseTypeZZ	 
(ZZ 
StatusCodesZZ )
.ZZ) *(
Status500InternalServerErrorZZ* F
)ZZF G
]ZZG H
public[[ 
async[[ 
Task[[ 
<[[ 
IActionResult[[ '
>[[' (
CreateUpdate[[) 5
([[5 6
[[[6 7
FromBody[[7 ?
][[? @

ServiceDto[[A K

serviceDTO[[L V
)[[V W
{\\ 	
try^^ 
{__ 
ifaa 
(aa 

serviceDTOaa 
==aa !
nullaa" &
)aa& '
{bb 
returncc 

BadRequestcc %
(cc% &

ModelStatecc& 0
)cc0 1
;cc1 2
}dd 
ifee 
(ee 
!ee 

ModelStateee 
.ee  
IsValidee  '
)ee' (
{ff 
returngg 

BadRequestgg %
(gg% &

ModelStategg& 0
)gg0 1
;gg1 2
}hh 
varjj 
servicejj 
=jj 
_mapperjj %
.jj% &
Mapjj& )
<jj) *
Servicejj* 1
>jj1 2
(jj2 3

serviceDTOjj3 =
)jj= >
;jj> ?
varkk 
responsekk 
=kk 
awaitkk $
_serviceRepositorykk% 7
.kk7 8
CreateUpdatekk8 D
(kkD E
servicekkE L
)kkL M
;kkM N
ifll 
(ll 
responsell 
==ll 
nullll  $
)ll$ %
{mm 
returnnn 

StatusCodenn %
(nn% &
$numnn& )
,nn) *
$strnn+ Z
)nnZ [
;nn[ \
}oo 
returnpp 
Okpp 
(pp 
responsepp "
)pp" #
;pp# $
}qq 
catchrr 
(rr 
	Exceptionrr 
)rr 
{ss 
returntt 

StatusCodett !
(tt! "
$numtt" %
,tt% &
$strtt' V
)ttV W
;ttW X
}uu 
}ww 	
[}} 	

HttpDelete}}	 
(}} 
$str}} 
)}} 
]}} 
[~~ 	 
ProducesResponseType~~	 
(~~ 
StatusCodes~~ )
.~~) *
Status400BadRequest~~* =
)~~= >
]~~> ?
[ 	 
ProducesResponseType	 
( 
StatusCodes )
.) *
Status404NotFound* ;
); <
]< =
[
ÄÄ 	"
ProducesResponseType
ÄÄ	 
(
ÄÄ 
StatusCodes
ÄÄ )
.
ÄÄ) * 
Status204NoContent
ÄÄ* <
)
ÄÄ< =
]
ÄÄ= >
[
ÅÅ 	"
ProducesResponseType
ÅÅ	 
(
ÅÅ 
StatusCodes
ÅÅ )
.
ÅÅ) **
Status500InternalServerError
ÅÅ* F
)
ÅÅF G
]
ÅÅG H
public
ÇÇ 
async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
IActionResult
ÇÇ '
>
ÇÇ' (
Delete
ÇÇ) /
(
ÇÇ/ 0
int
ÇÇ0 3
id
ÇÇ4 6
)
ÇÇ6 7
{
ÉÉ 	
try
ÑÑ 
{
ÖÖ 
if
ÜÜ 
(
ÜÜ 
id
ÜÜ 
<
ÜÜ 
$num
ÜÜ 
)
ÜÜ 
{
áá 
return
àà 

BadRequest
àà %
(
àà% &
)
àà& '
;
àà' (
}
ââ 
var
ää 
service
ää 
=
ää 
await
ää # 
_serviceRepository
ää$ 6
.
ää6 7
GetById
ää7 >
(
ää> ?
id
ää? A
)
ääA B
;
ääB C
if
ãã 
(
ãã 
service
ãã 
==
ãã 
null
ãã #
)
ãã# $
{
åå 
return
çç 
NotFound
çç #
(
çç# $
)
çç$ %
;
çç% &
}
éé 
var
èè 
	isSuccess
èè 
=
èè 
await
èè  % 
_serviceRepository
èè& 8
.
èè8 9
Delete
èè9 ?
(
èè? @
service
èè@ G
)
èèG H
;
èèH I
if
êê 
(
êê 
!
êê 
	isSuccess
êê 
)
êê 
{
ëë 
return
íí 

StatusCode
íí %
(
íí% &
$num
íí& )
,
íí) *
$str
íí+ Z
)
ííZ [
;
íí[ \
}
ìì 
return
îî 
	NoContent
îî  
(
îî  !
)
îî! "
;
îî" #
}
ïï 
catch
ññ 
(
ññ 
	Exception
ññ 
)
ññ 
{
óó 
return
òò 

StatusCode
òò !
(
òò! "
$num
òò" %
,
òò% &
$str
òò' V
)
òòV W
;
òòW X
}
ôô 
}
öö 	
}
õõ 
}úú Õ

]C:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Program.cs
	namespace

 	
deusbarbershop


 
{ 
public 

static 
class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public   
static   
IHostBuilder   "
CreateHostBuilder  # 4
(  4 5
string  5 ;
[  ; <
]  < =
args  > B
)  B C
=>  D F
Host!! 
.!!  
CreateDefaultBuilder!! %
(!!% &
args!!& *
)!!* +
."" $
ConfigureWebHostDefaults"" )
("") *

webBuilder""* 4
=>""5 7
{## 

webBuilder$$ 
.$$ 

UseStartup$$ )
<$$) *
Startup$$* 1
>$$1 2
($$2 3
)$$3 4
;$$4 5
}%% 
)%% 
;%% 
}&& 
}'' ∫
wC:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Request\RequestAppointmentDetails.cs
	namespace 	
deusbarbershop
 
. 
Request  
{ 
public 

class %
RequestAppointmentDetails *
{ 
public 
int 
ID 
{ 
get 
; 
set  
;  !
}" #
public 
DateTime 
Date 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 

Service_Id 
{ 
get  #
;# $
set% (
;( )
}* +
public   
Customer   
Customer    
{  ! "
get  # &
;  & '
set  ( +
;  + ,
}  - .
}"" 
}## ¡
rC:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Response\ResponseAppointment.cs
	namespace 	
deusbarbershop
 
. 
Response !
{ 
public 

class 
ResponseAppointment $
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
DateTime 
AppointmentDate '
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
CustomerName "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
ServiceName !
{" #
get$ '
;' (
set) ,
;, -
}. /
}!! 
}"" ˛6
]C:\Users\giwrg\OneDrive\Desktop\ICT\Semester3\DeusBarberShopService\deusbarbershop\Startup.cs
	namespace 	
deusbarbershop
 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public$$ 
IConfiguration$$ 
Configuration$$ +
{$$, -
get$$. 1
;$$1 2
}$$3 4
public++ 
void++ 
ConfigureServices++ %
(++% &
IServiceCollection++& 8
services++9 A
)++A B
{,, 	
services-- 
.-- 
AddDbContext-- !
<--! " 
ApplicationDbContext--" 6
>--6 7
(--7 8
options--8 ?
=>--@ B
options.. 
... 
	UseNpgsql.. !
(..! "
Configuration// !
.//! "
GetConnectionString//" 5
(//5 6
$str//6 I
)//I J
)//J K
)//K L
;//L M
services00 
.00 3
'AddDatabaseDeveloperPageExceptionFilter00 <
(00< =
)00= >
;00> ?
services11 
.11 
AddDefaultIdentity11 '
<11' (
ApplicationOwner11( 8
>118 9
(119 :
)11: ;
.22 
AddRoles22 
<22 
IdentityRole22 &
>22& '
(22' (
)22( )
.33 $
AddEntityFrameworkStores33 )
<33) * 
ApplicationDbContext33* >
>33> ?
(33? @
)33@ A
;33A B
services55 
.55 
AddAutoMapper55 "
(55" #
typeof55# )
(55) *
Deus_Models55* 5
.555 6
Maps556 :
.55: ;
Map55; >
)55> ?
)55? @
;55@ A
services66 
.66 
AddSwaggerGen66 "
(66" #
c66# $
=>66$ &
{66' (
c77 
.77 

SwaggerDoc77 
(77 
$str77 !
,77! "
new77# &
OpenApiInfo77' 2
{88 
Version99 
=99 
$str99 "
,99" #
Title:: 
=:: 
$str:: 0
,::0 1
Description;; 
=;;  !
$str;;" 2
}>> 
)>> 
;>> 
var?? 
xFile?? 
=?? 
$"?? 
{?? 
Assembly?? '
.??' ( 
GetExecutingAssembly??( <
(??< =
)??= >
.??> ?
GetName??? F
(??F G
)??G H
.??H I
Name??I M
}??M N
$str??N R
"??R S
;??S T
var@@ 
xPath@@ 
=@@ 
Path@@  
.@@  !
Combine@@! (
(@@( )

AppContext@@) 3
.@@3 4
BaseDirectory@@4 A
,@@A B
xFile@@C H
)@@H I
;@@I J
cAA 
.AA 
IncludeXmlCommentsAA $
(AA$ %
xPathAA% *
)AA* +
;AA+ ,
}BB 
)BB 
;BB 
servicesDD 
.DD 
	AddScopedDD 
<DD 
ICustomerRepositoryDD 2
,DD2 3
CustomerRepositoryDD4 F
>DDF G
(DDG H
)DDH I
;DDI J
servicesEE 
.EE 
	AddScopedEE 
<EE "
IAppointmentRepositoryEE 5
,EE5 6!
AppointmentRepositoryEE7 L
>EEL M
(EEM N
)EEN O
;EEO P
servicesFF 
.FF 
	AddScopedFF 
<FF 
IServiceRepositoryFF 1
,FF1 2
ServiceRepositoryFF3 D
>FFD E
(FFE F
)FFF G
;FFG H
servicesJJ 
.JJ 
AddControllersJJ #
(JJ# $
)JJ$ %
.JJ% &
AddNewtonsoftJsonJJ& 7
(JJ7 8
optionsJJ8 ?
=>JJ@ B
optionsLL 
.LL 
SerializerSettingsLL *
.LL* +!
ReferenceLoopHandlingLL+ @
=MM 

NewtonsoftMM 
.MM 
JsonMM !
.MM! "!
ReferenceLoopHandlingMM" 7
.MM7 8
IgnoreMM8 >
)MM> ?
;MM? @
}NN 	
publicXX 
voidXX 
	ConfigureXX 
(XX 
IApplicationBuilderXX 1
appXX2 5
,XX5 6
IWebHostEnvironmentXX7 J
envXXK N
,XXN O
UserManagerYY 
<YY 
ApplicationOwnerYY (
>YY( )
userManagerYY* 5
,YY5 6
RoleManagerZZ 
<ZZ 
IdentityRoleZZ $
>ZZ$ %
roleManagerZZ& 1
)ZZ1 2
{[[ 	
if\\ 
(\\ 
env\\ 
.\\ 
IsDevelopment\\ !
(\\! "
)\\" #
)\\# $
{]] 
app^^ 
.^^ %
UseDeveloperExceptionPage^^ -
(^^- .
)^^. /
;^^/ 0
app__ 
.__ !
UseMigrationsEndPoint__ )
(__) *
)__* +
;__+ ,
}`` 
elseaa 
{bb 
appcc 
.cc 
UseExceptionHandlercc '
(cc' (
$strcc( 0
)cc0 1
;cc1 2
appee 
.ee 
UseHstsee 
(ee 
)ee 
;ee 
}ff 
apphh 
.hh 

UseSwaggerhh 
(hh 
)hh 
;hh 
appii 
.ii 
UseSwaggerUIii 
(ii 
cii 
=>ii !
{jj 
ckk 
.kk 
SwaggerEndpointkk !
(kk! "
$strkk" <
,kk< =
$strkk> N
)kkN O
;kkO P
cll 
.ll 
RoutePrefixll 
=ll 
stringll  &
.ll& '
Emptyll' ,
;ll, -
}mm 
)mm 
;mm 
appoo 
.oo 
UseHttpsRedirectionoo #
(oo# $
)oo$ %
;oo% &
apppp 
.pp 
UseCorspp 
(pp 
$strpp $
)pp$ %
;pp% &
apprr 
.rr 

UseRoutingrr 
(rr 
)rr 
;rr 
appss 
.ss 
UseAuthenticationss !
(ss! "
)ss" #
;ss# $
apptt 
.tt 
UseAuthorizationtt  
(tt  !
)tt! "
;tt" #
appuu 
.uu 
UseEndpointsuu 
(uu 
	endpointsuu &
=>uu' )
{vv 
	endpointsww 
.ww 
MapControllersww (
(ww( )
)ww) *
;ww* +
}xx 
)xx 
;xx 
}yy 	
}zz 
}{{ 