//
// FontAwesome.cs
//
// Author:
//       Neil Kennedy <neil.p.kennedy@outlook.com>
//
// Copyright (c) 2014 neilkennedy
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoTouch.UIKit;

namespace FontAwesomeXamarin
{
	public class FontAwesome
	{
		public static UIFont Font (float size) {
			return UIFont.FromName ("FontAwesome", size);
		}

		public static string FontAwesomeIconStringForIconIdentifier(string identifier){
			switch(identifier){
			case "fa-adjust":
				return FAAdjust;
			case "fa-adn":
				return FAAdn;
			case "fa-align-center":
				return FAAlignCenter;
			case "fa-align-justify":
				return FAAlignJustify;
			case "fa-align-left":
				return FAAlignLeft;
			case "fa-align-right":
				return FAAlignRight;
			case "fa-ambulance":
				return FAAmbulance;
			case "fa-anchor":
				return FAAnchor;
			case "fa-android":
				return FAAndroid;
			case "fa-angellist":
				return FAAngelList;
			case "fa-angle-double-down":
				return FAAngleDoubleDown;
			case "fa-angle-double-left":
				return FAAngleDoubleLeft;
			case "fa-angle-double-right":
				return FAAngleDoubleRight;
			case "fa-angle-double-up":
				return FAAngleDoubleUp;
			case "fa-angle-down":
				return FAAngleDown;
			case "fa-angle-left":
				return FAAngleLeft;
			case "fa-angle-right":
				return FAAngleRight;
			case "fa-angle-up":
				return FAAngleUp;
			case "fa-apple":
				return FAApple;
			case "fa-archive":
				return FAArchive;
			case "fa-area-chart":
				return FAAreaChart;
			case "fa-arrow-circle-down":
				return FAArrowCircleDown;
			case "fa-arrow-circle-left":
				return FAArrowCircleLeft;
			case "fa-arrow-circle-o-down":
				return FAArrowCircleODown;
			case "fa-arrow-circle-o-left":
				return FAArrowCircleOLeft;
			case "fa-arrow-circle-o-right":
				return FAArrowCircleORight;
			case "fa-arrow-circle-o-up":
				return FAArrowCircleOUp;
			case "fa-arrow-circle-right":
				return FAArrowCircleRight;
			case "fa-arrow-circle-up":
				return FAArrowCircleUp;
			case "fa-arrow-down":
				return FAArrowDown;
			case "fa-arrow-left":
				return FAArrowLeft;
			case "fa-arrow-right":
				return FAArrowRight;
			case "fa-arrow-up":
				return FAArrowUp;
			case "fa-arrows":
				return FAArrows;
			case "fa-arrows-alt":
				return FAArrowsAlt;
			case "fa-arrows-h":
				return FAArrowsH;
			case "fa-arrows-v":
				return FAArrowsV;
			case "fa-asterisk":
				return FAAsterisk;
			case "fa-at":
				return FAAt;
			case "fa-automobile":
				return FAAutomobile;
			case "fa-backward":
				return FABackward;
			case "fa-ban":
				return FABan;
			case "fa-bank":
				return FABank;
			case "fa-bar-chart":
				return FABarChart;
			case "fa-bar-chart-o":
				return FABarChartO;
			case "fa-bar-code":
				return FABarCode;
			case "fa-bars":
				return FABars;
			case "fa-beer":
				return FABeer;
			case "fa-behance":
				return FABehance;
			case "fa-behance-square":
				return FABehanceSquare;
			case "fa-bell":
				return FABell;
			case "fa-bell-o":
				return FABellO;
			case "fa-bell-slash":
				return FABellSlash;
			case "fa-bell-slash-o":
				return FABellSlashO;
			case "fa-bicycle":
				return FABicycle;
			case "fa-binoculars":
				return FABinoculars;
			case "fa-birthday-cake":
				return FABirthdayCake;
			case "fa-bitbucket":
				return FABitbucket;
			case "fa-bitbucket-square":
				return FABitbucketSquare;
			case "fa-bitcoin":
				return FABitcoin;
			case "fa-bold":
				return FABold;
			case "fa-bolt":
				return FABolt;
			case "fa-bomb":
				return FABomb;
			case "fa-book":
				return FABook;
			case "fa-bookmark":
				return FABookmark;
			case "fa-bookmark-o":
				return FABookmarkO;
			case "fa-briefcase":
				return FABriefcase;
			case "fa-btc":
				return FABtc;
			case "fa-bug":
				return FABug;
			case "fa-building":
				return FABuilding;
			case "fa-building-o":
				return FABuildingO;
			case "fa-bullhorn":
				return FABullhorn;
			case "fa-bullseye":
				return FABullseye;
			case "fa-bus":
				return FABus;
			case "fa-cab":
				return FACab;
			case "fa-calculator":
				return FACalculator;
			case "fa-calendar":
				return FACalendar;
			case "fa-calendar-o":
				return FACalendarO;
			case "fa-camera":
				return FACamera;
			case "fa-camera-retro":
				return FACameraRetro;
			case "fa-car":
				return FACar;
			case "fa-caret-down":
				return FACaretDown;
			case "fa-caret-left":
				return FACaretLeft;
			case "fa-caret-right":
				return FACaretRight;
			case "fa-caret-square-o-down":
				return FACaretSquareODown;
			case "fa-caret-square-o-left":
				return FACaretSquareOLeft;
			case "fa-caret-square-o-right":
				return FACaretSquareORight;
			case "fa-caret-square-o-up":
				return FACaretSquareOUp;
			case "fa-caret-up":
				return FACaretUp;
			case "fa-cc":
				return FACC;
			case "fa-cc-amex":
				return FACCAmex;
			case "fa-cc-discover":
				return FACCDiscover;
			case "fa-cc-mastercard":
				return FACCMastercard;
			case "fa-cc-paypal":
				return FACCPaypal;
			case "fa-cc-stripe":
				return FACCStripe;
			case "fa-cc-visa":
				return FACCVisa;
			case "fa-certificate":
				return FACertificate;
			case "fa-chain":
				return FAChain;
			case "fa-chain-broken":
				return FAChainBroken;
			case "fa-check":
				return FACheck;
			case "fa-check-circle":
				return FACheckCircle;
			case "fa-check-circle-o":
				return FACheckCircleO;
			case "fa-check-square":
				return FACheckSquare;
			case "fa-check-square-o":
				return FACheckSquareO;
			case "fa-chevron-circle-down":
				return FAChevronCircleDown;
			case "fa-chevron-circle-left":
				return FAChevronCircleLeft;
			case "fa-chevron-circle-right":
				return FAChevronCircleRight;
			case "fa-chevron-circle-up":
				return FAChevronCircleUp;
			case "fa-chevron-down":
				return FAChevronDown;
			case "fa-chevron-left":
				return FAChevronLeft;
			case "fa-chevron-right":
				return FAChevronRight;
			case "fa-chevron-up":
				return FAChevronUp;
			case "fa-child":
				return FAChild;
			case "fa-circle":
				return FACircle;
			case "fa-circle-o":
				return FACircleO;
			case "fa-circle-o-notch":
				return FACircleONotch;
			case "FACircleThin":
				return FACircleThin;
			case "fa-clipboard":
				return FAClipboard;
			case "fa-clock-o":
				return FAClockO;
			case "fa-close":
				return FAClose;
			case "fa-cloud":
				return FACloud;
			case "fa-cloud-download":
				return FACloudDownload;
			case "fa-cloud-upload":
				return FACloudUpload;
			case "fa-cny":
				return FACny;
			case "fa-code":
				return FACode;
			case "fa-code-fork":
				return FACodeFork;
			case "fa-codepen":
				return FACodepen;
			case "fa-coffee":
				return FACoffee;
			case "fa-cog":
				return FACog;
			case "fa-cogs":
				return FACogs;
			case "fa-columns":
				return FAColumns;
			case "fa-comment":
				return FAComment;
			case "fa-comment-o":
				return FACommentO;
			case "fa-comments":
				return FAComments;
			case "fa-comments-o":
				return FACommentsO;
			case "fa-compass":
				return FACompass;
			case "fa-compress":
				return FACompress;
			case "fa-copy":
				return FACopy;
			case "fa-copyright":
				return FACopyright;
			case "fa-credit-card":
				return FACreditCard;
			case "fa-crop":
				return FACrop;
			case "fa-crosshairs":
				return FACrosshairs;
			case "fa-css3":
				return FACSS3;
			case "fa-cube":
				return FACube;
			case "fa-cubes":
				return FACubes;
			case "fa-cut":
				return FACut;
			case "fa-cutlery":
				return FACutlery;
			case "fa-dashboard":
				return FADashboard;
			case "fa-database":
				return FADatabase;
			case "fa-dedent":
				return FADedent;
			case "fa-delicious":
				return FADelicious;
			case "fa-desktop":
				return FADesktop;
			case "fa-deviantart":
				return FADeviantart;
			case "fa-digg":
				return FADigg;
			case "fa-dollar":
				return FADollar;
			case "fa-dot-circle-o":
				return FADotCircleO;
			case "fa-download":
				return FADownload;
			case "fa-dribbble":
				return FADribbble;
			case "fa-dropbox":
				return FADropbox;
			case "fa-drupal":
				return FADrupal;
			case "fa-edit":
				return FAEdit;
			case "fa-eject":
				return FAEject;
			case "fa-ellipsis-h":
				return FAEllipsisH;
			case "fa-ellipsis-v":
				return FAEllipsisV;
			case "fa-empire":
				return FAEmpire;
			case "fa-envelope":
				return FAEnvelope;
			case "fa-envelope-o":
				return FAEnvelopeO;
			case "fa-envelope-square":
				return FAEnvelopeSquare;
			case "fa-eraser":
				return FAEraser;
			case "fa-eur":
				return FAEur;
			case "fa-euro":
				return FAEuro;
			case "fa-exchange":
				return FAExchange;
			case "fa-exclamation":
				return FAExclamation;
			case "fa-exclamation-circle":
				return FAExclamationCircle;
			case "fa-exclamation-triangle":
				return FAExclamationTriangle;
			case "fa-expand":
				return FAExpand;
			case "fa-external-link":
				return FAExternalLink;
			case "fa-external-linkSquare":
				return FAExternalLinkSquare;
			case "fa-eye":
				return FAEye;
			case "fa-eye-slash":
				return FAEyeSlash;
			case "fa-eye-dropper":
				return FAEyeDropper;
			case "fa-facebook":
				return FAFacebook;
			case "fa-facebook-square":
				return FAFacebookSquare;
			case "fa-fast-backward":
				return FAFastBackward;
			case "fa-fast-forward":
				return FAFastForward;
			case "fa-fax":
				return FAFax;
			case "fa-female":
				return FAFemale;
			case "fa-fighter-jet":
				return FAFighterJet;
			case "fa-file":
				return FAFile;
			case "fa-file-archive-o":
				return FAFileArchiveO;
			case "fa-file-audio-o":
				return FAFileAudioO;
			case "fa-file-code-o":
				return FAFileCodeO;
			case "fa-file-excel-o":
				return FAFileExcelO;
			case "fa-file-image-o":
				return FAFileImageO;
			case "fa-file-movie-o":
				return FAFileMovieO;
			case "fa-file-o":
				return FAFileO;
			case "fa-file-pdf-o":
				return FAFilePdfO;
			case "fa-file-photo-o":
				return FAFilePhotoO;
			case "fa-file-picture-o":
				return FAFilePictureO;
			case "fa-file-powerpoint-o":
				return FAFilePowerpointO;
			case "fa-file-sound-o":
				return FAFileSoundO;
			case "fa-file-text":
				return FAFileText;
			case "fa-file-text-o":
				return FAFileTextO;
			case "fa-file-video-o":
				return FAFileVideoO;
			case "fa-file-word-o":
				return FAFileWordO;
			case "fa-file-zip-o":
				return FAFileZipO;
			case "fa-files-o":
				return FAFilesO;
			case "fa-film":
				return FAFilm;
			case "fa-filter":
				return FAFilter;
			case "fa-fire":
				return FAFire;
			case "fa-fire-extinguisher":
				return FAFireExtinguisher;
			case "fa-flag":
				return FAFlag;
			case "fa-flag-checkered":
				return FAFlagCheckered;
			case "fa-flag-o":
				return FAFlagO;
			case "fa-flash":
				return FAFlash;
			case "fa-flask":
				return FAFlask;
			case "fa-flickr":
				return FAFlickr;
			case "fa-floppy-o":
				return FAFloppyO;
			case "fa-folder":
				return FAFolder;
			case "fa-folder-o":
				return FAFolderO;
			case "fa-folder-open":
				return FAFolderOpen;
			case "fa-folder-open-o":
				return FAFolderOpenO;
			case "fa-font":
				return FAFont;
			case "fa-forward":
				return FAForward;
			case "fa-foursquare":
				return FAFoursquare;
			case "fa-frown-o":
				return FAFrownO;
			case "fa-futbol-o":
				return FAFutbolO;
			case "fa-gamepad":
				return FAGamepad;
			case "fa-gavel":
				return FAGavel;
			case "fa-gbp":
				return FAGbp;
			case "fa-ge":
				return FAGE;
			case "fa-gear":
				return FAGear;
			case "fa-gears":
				return FAGears;
			case "fa-gift":
				return FAGift;
			case "fa-git":
				return FAGit;
			case "fa-git-square":
				return FAGitSquare;
			case "fa-github":
				return FAGithub;
			case "fa-github-alt":
				return FAGithubAlt;
			case "fa-github-square":
				return FAGithubSquare;
			case "fa-gittip":
				return FAGittip;
			case "fa-glass":
				return FAGlass;
			case "fa-globe":
				return FAGlobe;
			case "fa-google":
				return FAGoogle;
			case "fa-google-plus":
				return FAGooglePlus;
			case "fa-google-plus-square":
				return FAGooglePlusSquare;
			case "fa-google-wallet":
				return FAGoogleWallet;
	
			case "fa-graduation-cap":
				return FAGraduationCap;
			case "fa-group":
				return FAGroup;
			case "fa-h-square":
				return FAHSquare;
			case "fa-hacker-news":
				return FAHackerNews;
			case "fa-hand-o-down":
				return FAHandODown;
			case "fa-hand-o-left":
				return FAHandOLeft;
			case "fa-hand-o-right":
				return FAHandORight;
			case "fa-hand-o-up":
				return FAHandOUp;
			case "fa-hdd-o":
				return FAHddO;
			case "fa-header":
				return FAHeader;
			case "fa-headphones":
				return FAHeadphones;
			case "fa-heart":
				return FAHeart;
			case "fa-heart-o":
				return FAHeartO;
			case "fa-history":
				return FAHistory;
			case "fa-home":
				return FAHome;
			case "fa-hospital-o":
				return FAHospitalO;
			case "fa-html5":
				return FAHtml5;
			case "fa-ils":
				return FAIls;
			case "fa-image":
				return FAImage;
			case "fa-inbox":
				return FAInbox;
			case "fa-indent":
				return FAIndent;
			case "fa-info":
				return FAInfo;
			case "fa-info-circle":
				return FAInfoCircle;
			case "fa-inr":
				return FAINR;
			case "fa-instagram":
				return FAInstagram;
			case "fa-institution":
				return FAInstitution;
			case "fa-ioxhost":
				return FAIoxhost;
			case "fa-italic":
				return FAItalic;
			case "fa-joomla":
				return FAJoomla;
			case "fa-jpy":
				return FAJPY;
			case "fa-jsfiddle":
				return FAJSFiddle;
			case "fa-key":
				return FAKey;
			case "fa-keyboard-o":
				return FAKeyboardO;
			case "fa-krw":
				return FAKrw;
			case "fa-language":
				return FALanguage;
			case "fa-laptop":
				return FALaptop;
			case "fa-lastfm":
				return FALastfm;
			case "fa-lastfm-square":
				return FALastfmSquare;
			case "fa-leaf":
				return FALeaf;
			case "fa-legal":
				return FALegal;
			case "fa-lemon-o":
				return FALemonO;
			case "fa-level-down":
				return FALevelDown;
			case "fa-level-up":
				return FALevelUp;
			case "fa-life-bouy":
				return FALifeBouy;
			case "fa-life-ring":
				return FALifeRing;
			case "fa-life-saver":
				return FALifeSaver;
			case "fa-lightbulb-o":
				return FALightbulbO;
			case "fa-line-chart":
				return FALineChart;
			case "fa-link":
				return FALink;
			case "fa-linkedin":
				return FALinkedin;
			case "fa-linkedin-square":
				return FALinkedinSquare;
			case "fa-linux":
				return FALinux;
			case "fa-list":
				return FAList;
			case "fa-list-alt":
				return FAListAlt;
			case "fa-list-ol":
				return FAListOl;
			case "fa-list-ul":
				return FAListUl;
			case "fa-location-arrow":
				return FALocationArrow;
			case "fa-lock":
				return FALock;
			case "fa-long-arrow-down":
				return FALongArrowDown;
			case "fa-long-arrow-left":
				return FALongArrowLeft;
			case "fa-long-arrow-right":
				return FALongArrowRight;
			case "fa-long-arrow-up":
				return FALongArrowUp;
			case "fa-magic":
				return FAMagic;
			case "fa-magnet":
				return FAMagnet;
			case "fa-mail-forward":
				return FAMailForward;
			case "fa-mail-reply":
				return FAMailReply;
			case "fa-mail-reply-all":
				return FAMailReplyAll;
			case "fa-male":
				return FAMale;
			case "fa-map-marker":
				return FAMapMarker;
			case "fa-maxcdn":
				return FAMaxcdn;
			case "fa-meanpath":
				return FAMeanpath;
			case "fa-medkit":
				return FAMedkit;
			case "fa-meh-o":
				return FAMehO;
			case "fa-microphone":
				return FAMicrophone;
			case "fa-microphone-slash":
				return FAMicrophoneSlash;
			case "fa-minus":
				return FAMinus;
			case "fa-minus-circle":
				return FAMinusCircle;
			case "fa-minus-square":
				return FAMinusSquare;
			case "fa-minus-square-o":
				return FAMinusSquareO;
			case "fa-mobile":
				return FAMobile;
			case "fa-mobile-phone":
				return FAMobilePhone;
			case "fa-money":
				return FAMoney;
			case "fa-moon-o":
				return FAMoonO;
			case "fa-mortar-board":
				return FAMortarBoard;
			case "fa-music":
				return FAMusic;
			case "fa-navicon":
				return FANavicon;
			case "fa-newspaper-o":
				return FANewsPaperO;
			case "fa-openid":
				return FAOpenid;
			case "fa-outdent":
				return FAOutdent;
			case "fa-pagelines":
				return FAPagelines;
			case "fa-paint-brush":
				return FAPaintBrush;
			case "fa-paper-plane":
				return FAPaperPlane;
			case "fa-paper-plane-o":
				return FAPaperPlaneO;
			case "fa-paper-clip":
				return FAPaperClip;
			case "fa-paragraph":
				return FAParagraph;
			case "fa-paste":
				return FAPaste;
			case "fa-pause":
				return FAPause;
			case "fa-paw":
				return FAPaw;
			case "fa-paypal":
				return FAPaypal;
			case "fa-pencil":
				return FAPencil;
			case "fa-pencil-square":
				return FAPencilSquare;
			case "fa-pencil-square-o": 
				return FAPencilSquareO; 
			case "fa-phone": 
				return FAPhone; 
			case "fa-phone-square": 
				return FAPhoneSquare; 
			case "fa-photo": 
				return FAPhoto; 

			case "fa-picture-o": 
				return FAPictureO; 

			case "fa-pie-chart": 
				return FAPieChart; 

			case "fa-pied-piper": 
				return FAPiedPiper; 

			case "fa-pied-piper-alt":
				return FAPiedPiperAlt; 

			case "fa-pinterest":
				return FAPinterest;

			case "fa-pinterest-square": 
				return FAPinterestSquare; 

			case "fa-plane": 
				return FAPlane; 

			case "fa-play": 
				return FAPlay; 

			case "fa-play-circle":
				return FAPlayCircle; 

			case "fa-play-circle-o":
				return FAPlayCircleO; 

			case "fa-plug":
				return FAPlug;

			case "fa-plus": 
				return FAPlus;

			case "fa-plus-circle": 
				return FAPlusCircle; 

			case "fa-plus-square": 
				return FAPlusSquare; 

			case "fa-plus-square-o": 
				return FAPlusSquareO; 

			case "fa-power-off":
				return FAPowerOff;

			case "fa-print":
				return FAPrint; 

			case "fa-puzzle-piece": 
				return FAPuzzlePiece;

			case "fa-qq":
				return FAQq; 

			case "fa-qrcode":
				return FAQRCode; 

			case "fa-question": 
				return FAQuestion; 

			case "fa-question-circle": 
				return FAQuestionCircle; 

			case "fa-quote-left":
				return FAQuoteLeft = "\uf10d";

			case "fa-quote-right":
				return FAQuoteRight; 

			case "fa-ra":
				return FARA;

			case "fa-random": 
				return FARandom; 
			case "fa-rebel":
				return FARebel; 

			case "fa-recycle": 
				return FARecycle; 

			case "fa-reddit": 
				return FAReddit; 

			case "fa-reddit-square":
				return FARedditSquare; 

			case "fa-refresh": 
				return FARefresh; 

			case "fa-remove":
				return FARemove; 

			case "fa-renren": 
				return FARenren; 

			case "fa-reorder": 
				return FAReorder;

			case "fa-repeat":
				return FARepeat;

			case "fa-reply":
				return FAReply;

			case "fa-replyAll":
				return FAReplyAll;

			case "fa-retweet":
				return FARetweet;

			case "fa-rmb": 
				return FARMB; 

			case "fa-road8": 
				return FARoad;

			case "fa-rocket":
				return FARocket;

			case "fa-rotate-eft":
				return FARotateLeft;

			case "fa-rotate-right":
				return FARotateRight = "\uf01e";

			case "fa-rouble":
				return FARouble;

			case "fa-rss":
				return FARSS;

			case "fa-rss-square":
				return FARSSSquare;

			case "fa-rub": 
				return FARub;

			case "fa-ruble":
				return FARuble;

			case "fa-rupee":
				return FARupee;


			case "fa-save":
				return FASave;

			case "fa-scissors":
				return FAScissors;

			case "fa-search":
				return FASearch;

			case "fa-search-minus":
				return FASearchMinus;

			case "fa-search-plus":
				return FASearchPlus;

			case "fa-send":
				return FASend;

			case "fa-send-o":
				return FASendO;

			case "fa-share": 
				return FAShare;

			case "fa-share-alt":
				return FAShareAlt;

			case "fa-share-alt-square":
				return FAShareAltSquare;

			case "fa-share-square":
				return FAShareSquare;

			case "fa-share-square-o":
				return FAShareSquareO;

			case "fa-shekel":
				return FAShekel;

			case "fa-sheqel":
				return FASheqel;

			case "fa-shield":
				return FAShield;

			case "fa-shopping-cart":
				return FAShoppingCart;

			case "fa-sign-in":
				return FASignIn;


			case "fa-sign-out":
				return FASignOut;

			case "fa-signal":
				return FASignal;

			case "fa-sitemap":
				return FASitemap;

			case "fa-skype":
				return FASkype;

			case "fa-slack":
				return FASlack;

			case "fa-sliders":
				return FASliders;

			case "fa-slideshare":
				return FASlideshare;

			case "fa-smile-o":
				return FASmileO;

			case "fa-soccer-ball-o":
				return FASoccerBallO;

			case "fa-sort-alpha-asc":
				return FASortAlphaAsc;

			case "fa-sort-alpha-desc":
				return FASortAlphaDesc;

			case "fa-sort-amount-asc":
				return FASortAmountAsc;

			case "fa-sort-amount-desc":
				return FASortAmountDesc;

			case "fa-sort-asc":
				return FASortAsc;

			case "fa-sort-desc":
				return FASortDesc;

			case "fa-sort-down":
				return FASortDown;

			case "fa-sort-numeric-asc":
				return FASortNumericAsc;

			case "fa-sort-numeric-desc":
				return FASortNumericDesc;

			case "fa-sort-up": 
				return FASortUp;

			case "fa-sound-cloud":
				return FASoundCloud;

			case "fa-space-shuttle":
				return FASpaceShuttle;

			case "fa-spinner":
				return FASpinner;

			case "fa-spoon":
				return FASpoon;

			case "fa-spotify":
				return FASpotify;

			case "fa-square":
				return FASquare;

			case "fa-square-o":
				return FASquareO;

			case "fa-stack-exchange":
				return FAStackExchange;

			case "fa-stack-overflow":
				return FAStackOverflow;

			case "fa-star": 
				return FAStar;

			case "fa-star-half":
				return FAStarHalf;

			case "fa-star-half-empty":
				return FAStarHalfEmpty;

			case "fa-star-half-full":
				return FAstarHalfFull;

			case "fa-star-half-o":
				return FAStarHalfO;

			case "fa-star-o": 
				return FAStarO;

			case "fa-steam":
				return FASteam;

			case "fa-steam-square":
				return FASteamSquare;

			case "fa-step-backward":
				return FAStepBackward;

			case "fa-step-forward":
				return FAStepForward;

			case "fa-stethoscope":
				return FAStethoscope;

			case "fa-stop": 
				return FAStop;

			case "fa-strikethrough":
				return FAStrikethrough;

			case "fa-stumbleupon":
				return FAStumbleupon;

			case "fa-stumbleupon-circle":
				return FAStumbleuponCircle;

			case "fa-subscript": 
				return FASubscript;

			case "fa-suitcase":
				return FASuitcase;

			case "fa-sun-o":
				return FASunO;

			case "fa-superscript":
				return FASuperscript;

			case "fa-support":
				return FASupport;


			case "fa-table":
				return FATable;

			case "fa-tablet":
				return FATablet;

			case "fa-tachometer":
				return FATachometer;

			case "fa-tag":
				return FATag;

			case "fa-tags":
				return FATags;

			case "fa-tasks":
				return FATasks;

			case "fa-taxi":
				return FATaxi;

			case "fa-tencent-weibo":
				return FATencentWeibo;

			case "fa-terminal":
				return FATerminal;

			case "fa-text-height":
				return FATextHeight;

			case "fa-text-width":
				return FATextWidth;

			case "fa-th":
				return FATH;

			case "fa-tf-large":
				return FATHLarge;

			case "fa-th-list":
				return FATHList;

			case "fa-thumb-tack":
				return FAThumbTack;

			case "fa-thumbs-down":
				return FAThumbsDown;

			case "fa-thumbs-o-down":
				return FAThumbsODown;

			case "fa-thumbs-o-up":
				return FAThumbsOUp;

			case "fa-thumbs-up":
				return FAThumbsUp;

			case "fa-ticket":
				return FATicket;

			case "fa-times":
				return FATimes;

			case "fa-times-circle":
				return FATimesCircle;

			case "fa-times-circle-o":
				return FATimesCircleO;

			case "fa-tint": 
				return FATint;

			case "fa-toggle-down":
				return FAToggleDown;

			case "fa-toggle-left":
				return FAToggleLeft;

			case "fa-toggle-off":
				return FAToggleOff;

			case "fa-toggle-on":
				return FAToggleOn;

			case "fa-toggle-right":
				return FAToggleRight;

			case "fa-toggle-up":
				return FAToggleUp;

			case "fa-trash":
				return FATrash;

			case "fa-trash-o":
				return FATrashO;

			case "fa-tree":
				return FATree;

			case "fa-trello":
				return FATrello;

			case "fa-trophy":
				return FATrophy;

			case "fa-truck":
				return FATruck;

			case "fa-try":
				return FATry;

			case "fa-tty":
				return FATty;

			case "fa-tumblr":
				return FATumblr;

			case "fa-tumblr-square": 
				return FAtTumblrSquare;

			case "fa-turkish-lira":
				return FATurkishLira;

			case "fa-twitch":
				return FATwitch;

			case "fa-twitter":
				return FATwitter;

			case "fa-twitter-square":
				return FATwitterSquare;

			case "fa-umbrella":
				return FAUmbrella;

			case "fa-underline":
				return FAUnderline;

			case "fa-undo":
				return FAUndo;

			case "fa-university":
				return FAUniversity; 

			case "fa-unlink": 
				return FAUnlink;

			case "fa-unlock":
				return FAUnlock;

			case "fa-unlock-alt":
				return FAUnlockAlt;

			case "fa-unsorted":
				return FAUnsorted;

			case "fa-upload":
				return FAUpload;

			case "fa-usd":
				return FAUSD;

			case "fa-user":
				return FAUser;

			case "fa-user-md":
				return FAUserMd;

			case "fa-users":
				return FAUsers;

			case "fa-video-camera":
				return FAVideoCamera;

			case "fa-vimeo-square":
				return FAVimeoSquare;

			case "fa-vine":
				return FAVine;

			case "fa-vk":
				return FAVK;

			case "fa-volume-down":
				return FAVolumeDown;

			case "fa-volume-off":
				return FAVolumeOff;

			case "fa-volume-up":
				return FAVolumeUp;

			case "fa-warning":
				return FAWarning;

			case "fa-wechat":
				return FAWechat;

			case "fa-weibo":
				return FAWeibo;

			case "fa-weixin":
				return FAWeixin;

			case "fa-wheelchair":
				return FAWheelchair;

			case "fa-wifi": 
				return FAWifi;

			case "fa-windows":
				return FAWindows;

			case "fa-won":
				return FAWon;

			case "fa-wordpress":
				return FAWordpress;

			case "fa-wrench":
				return FAWrench;

			case "fa-xing":
				return FAXing;

			case "fa-xing-square":
				return FAXingSquare;

			case "fa-yahoo": 
				return FAYahoo;

			case "fa-yelp":
				return FAYelp;

			case "fa-yen":
				return FAYen;

			case "fa-youtube":
				return FAYoutube;

			case "fa-youtube-play":
				return FAYoutubePlay;

			case "fa-youtube-square":
				return FAYoutubeSquare;
			default:
				return FABolt;
			}
		}

//		public static string FontAwesomeIconStringForIconCode(string code){
//			switch(code){
//			case "&#xf042;":
//				return FAAdjust;
//			default:
//				return FABolt;
//			}
//		}
			

		public static string FAAdjust = "\uf042";
		public static string FAAdn = "\uf170";
		public static string FAAlignCenter = "\uf037"; 
		public static string FAAlignJustify = "\uf039"; 
		public static string FAAlignLeft = "\uf036"; 
		public static string FAAlignRight = "\uf038"; 
		public static string FAAmbulance = "\uf0f9"; 
		public static string FAAnchor = "\uf13d"; 
		public static string FAAndroid = "\uf17b"; 
		public static string FAAngelList = "\uf209"; 
		public static string FAAngleDoubleDown = "\uf103"; 
		public static string FAAngleDoubleLeft = "\uf100"; 
		public static string FAAngleDoubleRight = "\uf101"; 
		public static string FAAngleDoubleUp = "\uf102"; 
		public static string FAAngleDown = "\uf107"; 
		public static string FAAngleLeft = "\uf104"; 
		public static string FAAngleRight = "\uf105"; 
		public static string FAAngleUp = "\uf106";
		public static string FAApple = "\uf179"; 
		public static string FAArchive = "\uf187"; 
		public static string FAAreaChart = "\uf1fe"; 
		public static string FAArrowCircleDown = "\uf0ab"; 
		public static string FAArrowCircleLeft = "\uf0a8"; 
		public static string FAArrowCircleODown = "\uf01a"; 
		public static string FAArrowCircleOLeft = "\uf190"; 
		public static string FAArrowCircleORight = "\uf18e"; 
		public static string FAArrowCircleOUp = "\uf01b"; 
		public static string FAArrowCircleRight = "\uf0a9"; 
		public static string FAArrowCircleUp = "\uf0aa"; 
		public static string FAArrowDown = "\uf063";
		public static string FAArrowLeft = "\uf060"; 
		public static string FAArrowRight = "\uf061"; 
		public static string FAArrowUp = "\uf062"; 
		public static string FAArrows = "\uf047";
		public static string FAArrowsAlt = "\uf0b2";
		public static string FAArrowsH = "\uf07e"; 
		public static string FAArrowsV = "\uf07d"; 
		public static string FAAsterisk = "\uf069"; 
		public static string FAAt = "\uf1fa"; 
		public static string FAAutomobile = "\uf1b9"; 
		public static string FABackward = "\uf04a";
		public static string FABan = "\uf05e"; 
		public static string FABank = "\uf19c"; 
		public static string FABarChart = "\uf080"; 
		public static string FABarChartO = "\uf080"; 
		public static string FABarCode = "\uf02a"; 
		public static string FABars = "\uf0c9";
		public static string FABeer = "\uf0fc"; 
		public static string FABehance = "\uf1b4"; 
		public static string FABehanceSquare = "\uf1b5"; 
		public static string FABell = "\uf0f3"; 
		public static string FABellO = "\uf0a2"; 
		public static string FABellSlash = "\uf1f6"; 
		public static string FABellSlashO = "\uf1f7"; 
		public static string FABicycle = "\uf206"; 
		public static string FABinoculars = "\uf1e5";
		public static string FABirthdayCake = "\uf1fd"; 
		public static string FABitbucket = "\uf171"; 
		public static string FABitbucketSquare = "\uf172";
		public static string FABitcoin = "\uf15a";
		public static string FABold = "\uf032"; 
		public static string FABolt = "\uf0e7"; 
		public static string FABomb = "\uf1e2"; 
		public static string FABook = "\uf02d"; 
		public static string FABookmark = "\uf02e"; 
		public static string FABookmarkO = "\uf097"; 
		public static string FABriefcase = "\uf0b1"; 
		public static string FABtc = "\uf15a"; 
		public static string FABug = "\uf188"; 
		public static string FABuilding = "\uf1ad"; 
		public static string FABuildingO = "\uf0f7"; 
		public static string FABullhorn = "\uf0a1"; 
		public static string FABullseye = "\uf140"; 
		public static string FABus = "\uf207"; 
		public static string FACab = "\uf1ba"; 
		public static string FACalculator = "\uf1ec"; 
		public static string FACalendar = "\uf073"; 
		public static string FACalendarO = "\uf133"; 
		public static string FACamera = "\uf030"; 
		public static string FACameraRetro = "\uf083"; 
		public static string FACar = "\uf1b9"; 
		public static string FACaretDown = "\uf0d7"; 
		public static string FACaretLeft = "\uf0d9"; 
		public static string FACaretRight = "\uf0da"; 
		public static string FACaretSquareODown = "\uf150"; 
		public static string FACaretSquareOLeft = "\uf191"; 
		public static string FACaretSquareORight = "\uf152"; 
		public static string FACaretSquareOUp = "\uf151"; 
		public static string FACaretUp = "\uf0d8"; 
		public static string FACC = "\uf20a"; 
		public static string FACCAmex = "\uf1f3"; 
		public static string FACCDiscover = "\uf1f2"; 
		public static string FACCMastercard = "\uf1f1"; 
		public static string FACCPaypal = "\uf1f4";
		public static string FACCStripe = "\uf1f5"; 
		public static string FACCVisa = "\uf1f0";
		public static string FACertificate = "\uf0a3"; 
		public static string FAChain = "\uf0c1"; 
		public static string FAChainBroken = "\uf127"; 
		public static string FACheck = "\uf00c";
		public static string FACheckCircle = "\uf058"; 
		public static string FACheckCircleO = "\uf05d"; 
		public static string FACheckSquare = "\uf14a"; 
		public static string FACheckSquareO = "\uf046"; 
		public static string FAChevronCircleDown = "\uf13a"; 
		public static string FAChevronCircleLeft = "\uf137"; 
		public static string FAChevronCircleRight = "\uf138"; 
		public static string FAChevronCircleUp = "\uf139";
		public static string FAChevronDown = "\uf078"; 
		public static string FAChevronLeft = "\uf053";
		public static string FAChevronRight = "\uf054"; 
		public static string FAChevronUp = "\uf077"; 
		public static string FAChild = "\uf1ae"; 
		public static string FACircle = "\uf111"; 
		public static string FACircleO = "\uf10c"; 
		public static string FACircleONotch = "\uf1ce"; 
		public static string FACircleThin = "\uf1db"; 
		public static string FAClipboard = "\uf0ea"; 
		public static string FAClockO = "\uf017"; 
		public static string FAClose = "\uf00d"; 
		public static string FACloud = "\uf0c2"; 
		public static string FACloudDownload = "\uf0ed"; 
		public static string FACloudUpload = "\uf0ee";
		public static string FACny = "\uf157"; 
		public static string FACode = "\uf121"; 
		public static string FACodeFork = "\uf126"; 
		public static string FACodepen = "\uf1cb"; 
		public static string FACoffee = "\uf0f4"; 
		public static string FACog = "\uf013"; 
		public static string FACogs = "\uf085"; 
		public static string FAColumns = "\uf0db"; 
		public static string FAComment = "\uf075";
		public static string FACommentO = "\uf0e5"; 
		public static string FAComments = "\uf086"; 
		public static string FACommentsO = "\uf0e6"; 
		public static string FACompass = "\uf14e"; 
		public static string FACompress = "\uf066"; 
		public static string FACopy = "\uf0c5"; 
		public static string FACopyright = "\uf1f9"; 
		public static string FACreditCard = "\uf09d"; 
		public static string FACrop = "\uf125"; 
		public static string FACrosshairs = "\uf05b"; 
		public static string FACSS3 = "\uf13c";
		public static string FACube = "\uf1b2"; 
		public static string FACubes = "\uf1b3"; 
		public static string FACut = "\uf0c4"; 
		public static string FACutlery = "\uf0f5"; 
		public static string FADashboard = "\uf0e4"; 
		public static string FADatabase = "\uf1c0"; 
		public static string FADedent = "\uf03b"; 
		public static string FADelicious = "\uf1a5"; 
		public static string FADesktop = "\uf108"; 
		public static string FADeviantart = "\uf1bd"; 
		public static string FADigg = "\uf1a6"; 
		public static string FADollar = "\uf155"; 
		public static string FADotCircleO = "\uf192"; 
		public static string FADownload = "\uf019"; 
		public static string FADribbble = "\uf17d";
		public static string FADropbox = "\uf16b"; 
		public static string FADrupal = "\uf1a9"; 
		public static string FAEdit = "\uf044"; 
		public static string FAEject = "\uf052"; 
		public static string FAEllipsisH = "\uf141"; 
		public static string FAEllipsisV = "\uf142"; 
		public static string FAEmpire = "\uf1d1"; 
		public static string FAEnvelope = "\uf0e0"; 
		public static string FAEnvelopeO = "\uf003"; 
		public static string FAEnvelopeSquare = "\uf199"; 
		public static string FAEraser = "\uf12d"; 
		public static string FAEur = "\uf153"; 
		public static string FAEuro = "\uf153"; 
		public static string FAExchange = "\uf0ec"; 
		public static string FAExclamation = "\uf12a"; 
		public static string FAExclamationCircle = "\uf06a"; 
		public static string FAExclamationTriangle = "\uf071"; 
		public static string FAExpand = "\uf065"; 
		public static string FAExternalLink = "\uf08e"; 
		public static string FAExternalLinkSquare = "\uf14c"; 
		public static string FAEye = "\uf06e";
		public static string FAEyeSlash = "\uf070"; 
		public static string FAEyeDropper = "\uf1fb"; 
		public static string FAFacebook = "\uf09a"; 
		public static string FAFacebookSquare = "\uf082"; 
		public static string FAFastBackward = "\uf049"; 
		public static string FAFastForward = "\uf050"; 
		public static string FAFax = "\uf1ac"; 
		public static string FAFemale = "\uf182"; 
		public static string FAFighterJet = "\uf0fb"; 
		public static string FAFile = "\uf15b"; 
		public static string FAFileArchiveO = "\uf1c6"; 
		public static string FAFileAudioO = "\uf1c7"; 
		public static string FAFileCodeO = "\uf1c9"; 
		public static string FAFileExcelO = "\uf1c3"; 
		public static string FAFileImageO = "\uf1c5"; 
		public static string FAFileMovieO = "\uf1c8"; 
		public static string FAFileO = "\uf016"; 
		public static string FAFilePdfO = "\uf1c1"; 
		public static string FAFilePhotoO = "\uf1c5"; 
		public static string FAFilePictureO = "\uf1c5"; 
		public static string FAFilePowerpointO = "\uf1c4"; 
		public static string FAFileSoundO = "\uf1c7"; 
		public static string FAFileText = "\uf15c"; 
		public static string FAFileTextO = "\uf0f6"; 
		public static string FAFileVideoO = "\uf1c8"; 
		public static string FAFileWordO = "\uf1c2"; 
		public static string FAFileZipO = "\uf1c6"; 
		public static string FAFilesO = "\uf0c5"; 
		public static string FAFilm = "\uf008"; 
		public static string FAFilter = "\uf0b0"; 
		public static string FAFire = "\uf06d"; 
		public static string FAFireExtinguisher = "\uf134"; 
		public static string FAFlag = "\uf024";
		public static string FAFlagCheckered = "\uf11e"; 
		public static string FAFlagO = "\uf11d"; 
		public static string FAFlash = "\uf0e7"; 
		public static string FAFlask = "\uf0c3"; 
		public static string FAFlickr = "\uf16e"; 
		public static string FAFloppyO = "\uf0c7"; 
		public static string FAFolder = "\uf07b";
		public static string FAFolderO = "\uf114"; 
		public static string FAFolderOpen = "\uf07c"; 
		public static string FAFolderOpenO = "\uf115";
		public static string FAFont = "\uf031";
		public static string FAForward = "\uf04e"; 
		public static string FAFoursquare = "\uf180"; 
		public static string FAFrownO = "\uf119"; 
		public static string FAFutbolO = "\uf1e3"; 
		public static string FAGamepad = "\uf11b"; 
		public static string FAGavel = "\uf0e3"; 
		public static string FAGbp = "\uf154";
		public static string FAGE = "\uf1d1"; 
		public static string FAGear = "\uf013"; 
		public static string FAGears = "\uf085"; 
		public static string FAGift = "\uf06b";
		public static string FAGit = "\uf1d3"; 
		public static string FAGitSquare = "\uf1d2"; 
		public static string FAGithub = "\uf09b"; 
		public static string FAGithubAlt = "\uf113";
		public static string FAGithubSquare = "\uf092"; 
		public static string FAGittip = "\uf184"; 
		public static string FAGlass = "\uf000"; 
		public static string FAGlobe = "\uf0ac"; 
		public static string FAGoogle = "\uf1a0"; 
		public static string FAGooglePlus = "\uf0d5"; 
		public static string FAGooglePlusSquare = "\uf0d4"; 
		public static string FAGoogleWallet = "\uf1ee"; 
		public static string FAGraduationCap = "\uf19d"; 
		public static string FAGroup = "\uf0c0"; 
		public static string FAHSquare = "\uf0fd"; 
		public static string FAHackerNews = "\uf1d4"; 
		public static string FAHandODown = "\uf0a7"; 
		public static string FAHandOLeft = "\uf0a5"; 
		public static string FAHandORight = "\uf0a4"; 
		public static string FAHandOUp = "\uf0a6"; 
		public static string FAHddO = "\uf0a0"; 
		public static string FAHeader = "\uf1dc"; 
		public static string FAHeadphones = "\uf025"; 
		public static string FAHeart = "\uf004";
		public static string FAHeartO = "\uf08a"; 
		public static string FAHistory = "\uf1da"; 
		public static string FAHome = "\uf015"; 
		public static string FAHospitalO = "\uf0f8"; 
		public static string FAHtml5 = "\uf13b"; 
		public static string FAIls = "\uf20b"; 
		public static string FAImage = "\uf03e"; 
		public static string FAInbox = "\uf01c"; 
		public static string FAIndent = "\uf03c"; 
		public static string FAInfo = "\uf129"; 
		public static string FAInfoCircle = "\uf05a";
		public static string FAINR = "\uf156";
		public static string FAInstagram = "\uf16d";
		public static string FAInstitution = "\uf19c"; 
		public static string FAIoxhost = "\uf208";
		public static string FAItalic = "\uf033"; 
		public static string FAJoomla = "\uf1aa"; 
		public static string FAJPY = "\uf157"; 
		public static string FAJSFiddle = "\uf1cc"; 
		public static string FAKey = "\uf084"; 
		public static string FAKeyboardO = "\uf11c"; 
		public static string FAKrw = "\uf159"; 
		public static string FALanguage = "\uf1ab"; 
		public static string FALaptop = "\uf109"; 
		public static string FALastfm = "\uf202"; 
		public static string FALastfmSquare = "\uf203"; 
		public static string FALeaf = "\uf06c"; 
		public static string FALegal = "\uf0e3"; 
		public static string FALemonO = "\uf094"; 
		public static string FALevelDown = "\uf149";
		public static string FALevelUp = "\uf148"; 
		public static string FALifeBouy = "\uf1cd"; 
		public static string FALifeBuoy = "\uf1cd"; 
		public static string FALifeRing = "\uf1cd"; 
		public static string FALifeSaver = "\uf1cd"; 
		public static string FALightbulbO = "\uf0eb"; 
		public static string FALineChart = "\uf201"; 
		public static string FALink = "\uf0c1"; 
		public static string FALinkedin = "\uf0e1";
		public static string FALinkedinSquare = "\uf08c"; 
		public static string FALinux = "\uf17c"; 
		public static string FAList = "\uf03a"; 
		public static string FAListAlt = "\uf022"; 
		public static string FAListOl = "\uf0cb";
		public static string FAListUl = "\uf0ca"; 
		public static string FALocationArrow = "\uf124"; 
		public static string FALock = "\uf023"; 
		public static string FALongArrowDown = "\uf175"; 
		public static string FALongArrowLeft = "\uf177"; 
		public static string FALongArrowRight = "\uf178";
		public static string FALongArrowUp = "\uf176"; 
		public static string FAMagic = "\uf0d0"; 
		public static string FAMagnet = "\uf076"; 
		public static string FAMailForward = "\uf064"; 
		public static string FAMailReply = "\uf112"; 
		public static string FAMailReplyAll = "\uf122"; 
		public static string FAMale = "\uf183"; 
		public static string FAMapMarker = "\uf041";
		public static string FAMaxcdn = "\uf136"; 
		public static string FAMeanpath = "\uf20c"; 
		public static string FAMedkit = "\uf0fa"; 
		public static string FAMehO = "\uf11a"; 
		public static string FAMicrophone = "\uf130"; 
		public static string FAMicrophoneSlash = "\uf131"; 
		public static string FAMinus = "\uf068";
		public static string FAMinusCircle = "\uf056"; 
		public static string FAMinusSquare = "\uf146"; 
		public static string FAMinusSquareO = "\uf147"; 
		public static string FAMobile = "\uf10b"; 
		public static string FAMobilePhone = "\uf10b"; 
		public static string FAMoney = "\uf0d6"; 
		public static string FAMoonO = "\uf186"; 
		public static string FAMortarBoard  = "\uf19d"; 
		public static string FAMusic = "\uf001"; 
		public static string FANavicon = "\uf0c9"; 
		public static string FANewsPaperO = "\uf1ea"; 
		public static string FAOpenid = "\uf19b"; 
		public static string FAOutdent = "\uf03b"; 
		public static string FAPagelines = "\uf18c"; 
		public static string FAPaintBrush = "\uf1fc"; 
		public static string FAPaperPlane = "\uf1d8"; 
		public static string FAPaperPlaneO = "\uf1d9"; 
		public static string FAPaperClip = "\uf0c6"; 
		public static string FAParagraph = "\uf1dd"; 
		public static string FAPaste = "\uf0ea"; 
		public static string FAPause = "\uf04c"; 
		public static string FAPaw = "\uf1b0"; 
		public static string FAPaypal = "\uf1ed"; 
		public static string FAPencil = "\uf040"; 
		public static string FAPencilSquare = "\uf14b"; 
		public static string FAPencilSquareO = "\uf044"; 
		public static string FAPhone = "\uf095"; 
		public static string FAPhoneSquare = "\uf098"; 
		public static string FAPhoto = "\uf03e"; 
		public static string FAPictureO = "\uf03e"; 
		public static string FAPieChart = "\uf200"; 
		public static string FAPiedPiper = "\uf1a7"; 
		public static string FAPiedPiperAlt = "\uf1a8"; 
		public static string FAPinterest = "\uf0d2";
		public static string FAPinterestSquare = "\uf0d3"; 
		public static string FAPlane = "\uf072"; 
		public static string FAPlay = "\uf04b"; 
		public static string FAPlayCircle = "\uf144"; 
		public static string FAPlayCircleO = "\uf01d"; 
		public static string FAPlug = "\uf1e6";
		public static string FAPlus = "\uf067"; 
		public static string FAPlusCircle = "\uf055"; 
		public static string FAPlusSquare = "\uf0fe"; 
		public static string FAPlusSquareO = "\uf196"; 
		public static string FAPowerOff = "\uf011";
		public static string FAPrint = "\uf02f"; 
		public static string FAPuzzlePiece = "\uf12e"; 
		public static string FAQq = "\uf1d6"; 
		public static string FAQRCode = "\uf029"; 
		public static string FAQuestion = "\uf128"; 
		public static string FAQuestionCircle = "\uf059"; 
		public static string FAQuoteLeft = "\uf10d";
		public static string FAQuoteRight = "\uf10e"; 
		public static string FARA = "\uf1d0";
		public static string FARandom = "\uf074"; 
		public static string FARebel = "\uf1d0"; 
		public static string FARecycle = "\uf1b8"; 
		public static string FAReddit = "\uf1a1"; 
		public static string FARedditSquare = "\uf1a2"; 
		public static string FARefresh = "\uf021"; 
		public static string FARemove = "\uf00d"; 
		public static string FARenren = "\uf18b"; 
		public static string FAReorder = "\uf0c9"; 
		public static string FARepeat = "\uf01e"; 
		public static string FAReply = "\uf112";
		public static string FAReplyAll = "\uf122"; 
		public static string FARetweet = "\uf079";
		public static string FARMB = "\uf157"; 
		public static string FARoad = "\uf018"; 
		public static string FARocket = "\uf135";
		public static string FARotateLeft = "\uf0e2"; 
		public static string FARotateRight = "\uf01e";
		public static string FARouble = "\uf158"; 
		public static string FARSS = "\uf09e"; 
		public static string FARSSSquare = "\uf143";
		public static string FARub = "\uf158"; 
		public static string FARuble = "\uf158"; 
		public static string FARupee = "\uf156"; 
		public static string FASave = "\uf0c7"; 
		public static string FAScissors = "\uf0c4"; 
		public static string FASearch = "\uf002";
		public static string FASearchMinus = "\uf010"; 
		public static string FASearchPlus = "\uf00e"; 
		public static string FASend = "\uf1d8";
		public static string FASendO = "\uf1d9"; 
		public static string FAShare = "\uf064"; 
		public static string FAShareAlt = "\uf1e0"; 
		public static string FAShareAltSquare = "\uf1e1"; 
		public static string FAShareSquare = "\uf14d"; 
		public static string FAShareSquareO = "\uf045"; 
		public static string FAShekel = "\uf20b"; 
		public static string FASheqel = "\uf20b"; 
		public static string FAShield = "\uf132"; 
		public static string FAShoppingCart = "\uf07a"; 
		public static string FASignIn = "\uf090"; 
		public static string FASignOut = "\uf08b"; 
		public static string FASignal = "\uf012"; 
		public static string FASitemap = "\uf0e8"; 
		public static string FASkype = "\uf17e"; 
		public static string FASlack = "\uf198"; 
		public static string FASliders = "\uf1de"; 
		public static string FASlideshare = "\uf1e7"; 
		public static string FASmileO = "\uf118"; 
		public static string FASoccerBallO = "\uf1e3"; 
		public static string FASortAlphaAsc = "\uf15d"; 
		public static string FASortAlphaDesc = "\uf15e"; 
		public static string FASortAmountAsc = "\uf160"; 
		public static string FASortAmountDesc = "\uf161"; 
		public static string FASortAsc = "\uf0de"; 
		public static string FASortDesc = "\uf0dd"; 
		public static string FASortDown = "\uf0dd"; 
		public static string FASortNumericAsc = "\uf162"; 
		public static string FASortNumericDesc = "\uf163"; 
		public static string FASortUp = "\uf0de"; 
		public static string FASoundCloud = "\uf1be";                        
		public static string FASpaceShuttle = "\uf197"; 
		public static string FASpinner = "\uf110"; 
		public static string FASpoon = "\uf1b1"; 
		public static string FASpotify = "\uf1bc"; 
		public static string FASquare = "\uf0c8"; 
		public static string FASquareO = "\uf096"; 
		public static string FAStackExchange = "\uf18d"; 
		public static string FAStackOverflow = "\uf16c"; 
		public static string FAStar = "\uf005"; 
		public static string FAStarHalf = "\uf089"; 
		public static string FAStarHalfEmpty = "\uf123"; 
		public static string FAstarHalfFull = "\uf123"; 
		public static string FAStarHalfO = "\uf123"; 
		public static string FAStarO = "\uf006"; 
		public static string FASteam = "\uf1b6"; 
		public static string FASteamSquare = "\uf1b7"; 
		public static string FAStepBackward = "\uf048";
		public static string FAStepForward = "\uf051";
		public static string FAStethoscope = "\uf0f1"; 
		public static string FAStop = "\uf04d"; 
		public static string FAStrikethrough = "\uf0cc"; 
		public static string FAStumbleupon = "\uf1a4";
		public static string FAStumbleuponCircle = "\uf1a3"; 
		public static string FASubscript = "\uf12c"; 
		public static string FASuitcase = "\uf0f2"; 
		public static string FASunO = "\uf185"; 
		public static string FASuperscript = "\uf12b"; 
		public static string FASupport = "\uf1cd";
		public static string FATable = "\uf0ce"; 
		public static string FATablet = "\uf10a"; 
		public static string FATachometer = "\uf0e4"; 
		public static string FATag = "\uf02b"; 
		public static string FATags = "\uf02c"; 
		public static string FATasks = "\uf0ae";
		public static string FATaxi = "\uf1ba"; 
		public static string FATencentWeibo = "\uf1d5"; 
		public static string FATerminal = "\uf120"; 
		public static string FATextHeight = "\uf034"; 
		public static string FATextWidth = "\uf035"; 
		public static string FATH = "\uf00a"; 
		public static string FATHLarge = "\uf009"; 
		public static string FATHList = "\uf00b"; 
		public static string FAThumbTack = "\uf08d"; 
		public static string FAThumbsDown = "\uf165"; 
		public static string FAThumbsODown = "\uf088"; 
		public static string FAThumbsOUp = "\uf087"; 
		public static string FAThumbsUp = "\uf164"; 
		public static string FATicket = "\uf145"; 
		public static string FATimes = "\uf00d"; 
		public static string FATimesCircle = "\uf057"; 
		public static string FATimesCircleO = "\uf05c"; 
		public static string FATint = "\uf043"; 
		public static string FAToggleDown = "\uf150"; 
		public static string FAToggleLeft = "\uf191"; 
		public static string FAToggleOff = "\uf204"; 
		public static string FAToggleOn = "\uf205"; 
		public static string FAToggleRight = "\uf152"; 
		public static string FAToggleUp = "\uf151"; 
		public static string FATrash = "\uf1f8"; 
		public static string FATrashO = "\uf014"; 
		public static string FATree = "\uf1bb"; 
		public static string FATrello = "\uf181"; 
		public static string FATrophy = "\uf091"; 
		public static string FATruck = "\uf0d1"; 
		public static string FATry = "\uf195"; 
		public static string FATty = "\uf1e4"; 
		public static string FATumblr = "\uf173"; 
		public static string FAtTumblrSquare = "\uf174"; 
		public static string FATurkishLira = "\uf195"; 
		public static string FATwitch = "\uf1e8";
		public static string FATwitter = "\uf099"; 
		public static string FATwitterSquare = "\uf081"; 
		public static string FAUmbrella = "\uf0e9"; 
		public static string FAUnderline = "\uf0cd"; 
		public static string FAUndo = "\uf0e2"; 
		public static string FAUniversity = "\uf19c"; 
		public static string FAUnlink = "\uf127"; 
		public static string FAUnlock = "\uf09c"; 
		public static string FAUnlockAlt = "\uf13e"; 
		public static string FAUnsorted = "\uf0dc"; 
		public static string FAUpload = "\uf093"; 
		public static string FAUSD = "\uf155";
		public static string FAUser = "\uf007"; 
		public static string FAUserMd = "\uf0f0"; 
		public static string FAUsers = "\uf0c0"; 
		public static string FAVideoCamera = "\uf03d"; 
		public static string FAVimeoSquare = "\uf194"; 
		public static string FAVine = "\uf1ca";
		public static string FAVK = "\uf189";
		public static string FAVolumeDown = "\uf027"; 
		public static string FAVolumeOff = "\uf026"; 
		public static string FAVolumeUp = "\uf028"; 
		public static string FAWarning = "\uf071"; 
		public static string FAWechat = "\uf1d7"; 
		public static string FAWeibo = "\uf18a"; 
		public static string FAWeixin = "\uf1d7"; 
		public static string FAWheelchair = "\uf193"; 
		public static string FAWifi = "\uf1eb"; 
		public static string FAWindows = "\uf17a"; 
		public static string FAWon = "\uf159"; 
		public static string FAWordpress = "\uf19a"; 
		public static string FAWrench = "\uf0ad"; 
		public static string FAXing = "\uf168"; 
		public static string FAXingSquare = "\uf169"; 
		public static string FAYahoo = "\uf19e"; 
		public static string FAYelp = "\uf1e9";
		public static string FAYen = "\uf157"; 
		public static string FAYoutube = "\uf167"; 
		public static string FAYoutubePlay = "\uf16a"; 
		public static string FAYoutubeSquare = "\uf166";

	}
}
